var psm = new ActiveXObject("PowerStateManagement.PowerStateManager");

WScript.Echo("hibernate pc");
psm.Hibernate();

//WScript.Echo("standby pc");
//psm.Standby();