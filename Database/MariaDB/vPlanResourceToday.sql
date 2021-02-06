DELIMITER $$

ALTER ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vplanresourcetoday` AS 
SELECT
  `planresources`.`ID_Resource`    AS `ID_Resource`,
  `planresources`.`PlanDate`       AS `PlanDate`,
  `planresources`.`Hour`           AS `Hour`,
  `projectsmembers`.`FirstName`    AS `FirstName`,
  `projectsmembers`.`LastName`     AS `LastName`,
  `adminresources`.`AdminResource` AS `AdminResource`,
  `projects`.`Title`               AS `Title`
FROM (((`planresources`
     LEFT JOIN `projectsmembers`
       ON (`planresources`.`CE_ID_ProjectMember` = `projectsmembers`.`ID_ProjectMember`))
    LEFT JOIN `adminresources`
      ON (`planresources`.`CE_ID_AdminResource` = `adminresources`.`ID_AdminResource`))
   LEFT JOIN `projects`
     ON (`planresources`.`CE_ID_Project` = `projects`.`ID_Project`))
WHERE `planresources`.`PlanDate` < CURDATE()
    AND `planresources`.`CE_ID_ProjectMember` <> 0
ORDER BY PLANDATE,HOUR ASC    
    $$

DELIMITER ;