using App.Shared;
using App.Library;
using App.Provider.Company;

IFeature builtin = new BuiltInFeature();
IFeature external = new ExternalFeature();

builtin.Test();
external.Test();
