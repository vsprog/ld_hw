var psm = new ActiveXObject("PowerStateManagement.PowerStateManager");

WScript.Echo("check hibernation file actions");
psm.ReserveHibernateFile();
WScript.Echo("file reserved");
psm.DeleteHibernateFile();
WScript.Echo("file deleted");