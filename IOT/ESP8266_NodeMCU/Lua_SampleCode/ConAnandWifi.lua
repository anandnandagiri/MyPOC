SSID = "Anand"
PW = "132020"
IPADR = "192.168.0.101"
IPROUTER = "192.168.0.1"

cfg={ssid = "AnandESP", pwd = "132020"}
wifi.sta.setip({ip=IPADR,netmask="255.255.255.0",gateway=IPROUTER})
wifi.setmode(wifi.STATIONAP)
wifi.sta.config(SSID,PW)
wifi.ap.config(cfg)

print(wifi.sta.getip())
print(wifi.ap.getip())