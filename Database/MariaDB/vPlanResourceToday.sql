SELECT
    `planresources`.`ID_Resource`
    , `planresources`.`PlanDate`
    , `planresources`.`Hour`
    , `projectsmembers`.`FirstName`
    , `projectsmembers`.`LastName`
    , `adminresources`.`AdminResource`
    , `projects`.`Title`
FROM
    `ProjectPlan`.`planresources`
    LEFT JOIN `ProjectPlan`.`projectsmembers` 
        ON (`planresources`.`CE_ID_ProjectMember` = `projectsmembers`.`ID_ProjectMember`)
    LEFT JOIN `ProjectPlan`.`adminresources` 
        ON (`planresources`.`CE_ID_AdminResource` = `adminresources`.`ID_AdminResource`)
    LEFT JOIN `ProjectPlan`.`projects` 
        ON (`planresources`.`CE_ID_Project` = `projects`.`ID_Project`)
WHERE (`planresources`.`PlanDate` < CURRENT_DATE()
    AND `planresources`.`CE_ID_ProjectMember` <>0);
