

Performance

	Adding cache headers to static files

		using Microsoft.Net.Http.Headers;
		app.UseStaticFiles(new StaticFileOptions
		{
			OnPrepareResponse = ctx =>
			{
				const int durationInSeconds = 60 * 60 * 24;
				ctx.Context.Response.Headers[HeaderNames.CacheControl] =
					"public,max-age=" + durationInSeconds;
			}
		});
		
		
		
Security
	
	Implemented HTTPS with Docker Nginx
	Implemented multiple Keys such as MyKey1, MyKey2, MyKey3 for Encryption and Decreprytion
	
	Implemented Don't display MYValue in Edit or Delete Action		
	
	Addition Security CAN Implement
		
		Login Screen With Captch
		Disable Browser Level Password Saving <INPUT TYPE="password" AUTOCOMPLETE="off">
		MyValue Not to cache on Browser

		robots.txt
			User-agent: *
			Disallow: /
	
	
