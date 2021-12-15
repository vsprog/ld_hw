var psm = new ActiveXObject("PowerStateManagement.PowerStateManager");

WScript.Echo("check stats");
WScript.Echo("last sleep time: " + psm.GetLastSleepTime());
WScript.Echo("last wake time: " + psm.GetLastWakeTime());
WScript.Echo("battery information:" + psm.GetSystemBatteryState());
WScript.Echo("power information:" + psm.GetSystemPowerInformation());
