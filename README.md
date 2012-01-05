How to use
==========

Initialize the API client with your key:

    Api.Init(APIKEY);

Widgets
-------

You can push to widgets like this:

    var counter = new Counter {
      Timestamp = DateTime.UtcNow,
      Value = 34
    };
    
    Api.Counters.Push(ID, counter, (result, error, cancelled) => { /* DONE */ });

You can also push multiple items:

    Api.Counters.Push(ID, new Counter[] { counter1, counter2 }, (result, error, cancelled) => { /* DONE */ });

### And the other widgets?

More examples are available in the Ducksboard.Console project.