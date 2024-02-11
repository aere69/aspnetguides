# Upload File Validation - ASPNet Core

This is an implementation of a robust file upload validation with Action Filters.
Upload Validation is crucial for ensuring the safety and integrity of our applications.

By implementing an action filter, we can add a custom attribute on the controller action of our choice which would take care of the validation.

To accomplish this we override `OnActionExecuting()` method and encapsulate the file validation logic inside.
This filter can now be easily reused without the need to duplicate file validation logic. 
