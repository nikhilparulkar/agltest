This Repository is for solution of a Coding Test.

It has two Components:

1) Web Backend  (RestFul WebAPI):
     1.1 )Developed in .Net Core 2.2 WebAPI. It follows S.O.L.I.D design principle with Abstraction for Services which can be injected at the start of project, Loosely Coupled Code , Modular Design and Global Exception handling.

     1.2) WebAPI exposes one endpoint : GET http://localhost:61647/Pets. 
          With Outputs :
          Result : 200(OK) {
                          "petsWithMaleOwner": [
                               "Tobby",
                               "Maggie"
                          ],
                          "petsWithfemalesOwner": [
                                "Xyz"
                          ] 
                      }

           Result : 500 (Internal Server Error) catches all program runtime exceptions.

    1.3) A unit test project is also included. It is developed in NUnit and Uses Mocking Framework MoQ to mock certain services for Unit testing puprposes.
 
2) Front App developed in Angular 1.4.


Installation :

      Download both Frontend and Backend App in your system.

      Ensure that .Net core 2.2 is installed.  

How To Run :

      Open the WebApI project .sln using MS Studion 2017 onwards and run the project in debug mode.
      
          
      Run the TestAGLEnergy.html in chrome or any browser.
      
How to Run Unit Test:

       Open the WebApI project .sln using MS Studion 2017 onwards . Go to MS Visual Studio IDE Test> Run (All test)
        
      
      
