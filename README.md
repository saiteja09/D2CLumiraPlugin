# D2CLumiraPlugin
SAP Lumira Data Access Extension Plugin using DataDirect Cloud Service

<strong>Steps to use the plugin:</strong></br>

1. If you are new to Progress DataDirect Cloud, please [register](https://pacific.progress.com/console/register?productName=d2c&ignoreCookie=true) yourself here for DataDirect Cloud account trial.

2.	[Login](https://secure.progress.com/oam/SSOPOST/metaAlias/External/psc-pacificconsole-idp) in to DataDirect cloud once you register. On the Left side, you will find a link Downloads, from where you can download Data Direct Cloud ODBC Drivers for Windows/ Linux. Download and install the Data Direct Cloud ODBC drivers file according to your OS. 
3.	Also download and install DataDirect Cloud On-Premise Connector if you plan to connect to a data source behind firewall.
4.  Once you are logged in, On the dashboard go to DataDirect Cloud and click on ‘Connect Data’.You will be redirected to Data Direct Cloud Dashboard. The first step here would be to create a Data Source definition. On the Dashboard, you can click on ‘Data Sources’ tab to the left of Dashboard and then you would have to click on ‘Data Stores’ on the Next Screen.
5.  Once you select your cloud data source, you will have to fill in details like Data Source Name – which can be any name you want, User Id and password for your Eloqua account and company Name. If your datasource is behind firewall open DataDirect On-Premise connector and copy the connector Id and paste it in your datasource General options for the field ‘Connector ID’
6. Once you have filled in those details, you can click on ‘Test Connection’. If it is successful, you will be notified and you can save the data source.
7. On your machine, create a new User data source in ODBC Administrator. Open ODBC Administrator -> Under User data sources, Add -> Select DataDirect Cloud 2.0 as your driver and give a datasource name and save it.
8. In order to use external data sources in SAP Lumira, we have to make couple of changes in SAP Lumira configuration file.Go to C:\Program Files\SAP Lumira\Desktop, Open SAPLumira.ini file and paste the following and save it.

 > -Dhilo.externalds.folder=C:\Program Files\SAP Lumira\Desktop\daextensions<br\>
 
 > -Dactivate.externaldatasource.ds=true

9.	Now create a folder named daextensions at directory C:\Program Files\SAP Lumira\Desktop
10.	Now copy the extension plugin in to the directory daextensions and restart your SAP Lumira, if you have opened it.
11.	After restart, Go to File -> New -> Select External Data Source ->  Select Eloqua Data Access plugin -> and click on Next.
12.	Enter your DataDirect Credentials on the form, DSN Name of ODBC driver for Data Direct Cloud that you have configured in ODBC administrator and click on Connect.
13.	If Authenticated successfully, you can Select the Entity that you want to use from the dropdown and Press OK to see preview of the data.

