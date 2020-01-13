/**
* Responds to any HTTP request.
*
* @param {!express:Request} req HTTP request context.
* @param {!express:Response} res HTTP response context.
*/
var url = require('url');
var Compute = require('@google-cloud/compute');
var compute = new Compute();
var vmzone = 'Your VM Zone';
var vmname ='Your VM Name';

exports.startmyvm = (req, res) => {	
	
	try
	{
		
		var q = url.parse(req.url, true).query;
		
		if(!(typeof q === 'undefined') && !(typeof q.restartvm === 'undefined'))
		{		
			console.log("In Restarting VM");
			compute.zone(vmzone)
					.vm(vmname)
					.stop()
					.then(data => {
						console.log('Stopping VM');
					})
					.then(() => {
						console.log('Successfully Stopped instance');
						compute.zone(vmzone)
							.vm(vmname)
							.start()
							.then(data => {
								console.log('Starting VM');
							})
							.then(() => {
								console.log('Successfully started instance');
							})
							.catch(err => {
							  console.log(err);				  
							});
					})
					.catch(err => {
					  console.log(err);				  
					});	
		}	
		else
		{
			compute.zone(vmzone)
					.vm(vmname)
					.start()
					.then(data => {
						console.log('Starting VM');
					})
					.then(() => {
						console.log('Successfully started instance');
					})
					.catch(err => {
					  console.log(err);				  
					});
		}
	}	
	catch (err) 
	{
		 console.log(err);
		 res.status(200).send('UnSuccess start instance..... Please Check Console');
	}	
	res.status(200).send('Success start instance');
};