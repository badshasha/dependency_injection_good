

configureDataService(service); // call it's in service method 



private void configureDataService(IserviceCollecion service){ // write private method 
    var client = new DynamoDbContext(new DynamoDbCOntextConfig()); // this thing not for me
    service.AddSigleTOn<IDynamoDbCotext , DynamoDbContext>();
}