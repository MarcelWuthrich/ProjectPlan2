DELIMITER $$

ALTER ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vprojectlist` AS 
SELECT
  `projects`.`ID_Project`,
  `projects`.`CE_ID_Status`,
  `status`.`Status`,
  `projects`.`CE_ID_ProjectManager`,
  `projects`.`CE_ID_Priority`,
  `projectmanagers`.`FirstName`,
  `projectmanagers`.`LastName`,
  `projects`.`CE_ID_Priority`,
  `projectpriority`.`Priority`,
  `projects`.`CE_ID_Category`,
  `projectcategories`.`Category`,
  `projects`.`CE_ID_Customer`,
  `customers`.`FirstName`,
  `customers`.`LastName`,
  `projects`.`CE_ID_Urgency`,
  `urgencies`.`Urgency`,
  `projects`.`Title`,
  `projects`.`Description`,
  `projects`.`BeginDate`,
  `projects`.`Deadline`,
  `projects`.`EstimatedResources`,
  `projects`.`ImplementationRate`,
  `projects`.`EffectiveResources`
FROM
  `ProjectPlan`.`vprojectlist`,
  `ProjectPlan`.`projects`
  INNER JOIN `ProjectPlan`.`status`
    ON (
      `projects`.`CE_ID_Status` = `status`.`ID_Status`
    )
  INNER JOIN `ProjectPlan`.`projectmanagers`
    ON (
      `projects`.`CE_ID_ProjectManager` = `projectmanagers`.`ID_ProjectManager`
    )
  INNER JOIN `ProjectPlan`.`projectcategories`
    ON (
      `projects`.`CE_ID_Category` = `projectcategories`.`ID_Category`
    )
  INNER JOIN `ProjectPlan`.`projectpriority`
    ON (
      `projects`.`CE_ID_Priority` = `projectpriority`.`ID_Priority`
    )
  INNER JOIN `ProjectPlan`.`customers`
    ON (
      `projects`.`CE_ID_Customer` = `customers`.`ID_Customer`
    )
  INNER JOIN `ProjectPlan`.`urgencies`
    ON (
      `projects`.`CE_ID_Urgency` = `urgencies`.`ID_Urgency`
    );$$



DELIMITER;

