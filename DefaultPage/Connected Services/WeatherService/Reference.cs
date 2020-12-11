﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DefaultPage.WeatherService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/findStore", ReplyAction="http://tempuri.org/IService/findStoreResponse")]
        string findStore(string zip, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/findStore", ReplyAction="http://tempuri.org/IService/findStoreResponse")]
        System.Threading.Tasks.Task<string> findStoreAsync(string zip, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FindAddress", ReplyAction="http://tempuri.org/IService/FindAddressResponse")]
        string FindAddress(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/FindAddress", ReplyAction="http://tempuri.org/IService/FindAddressResponse")]
        System.Threading.Tasks.Task<string> FindAddressAsync(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCrimeData", ReplyAction="http://tempuri.org/IService/getCrimeDataResponse")]
        string[] getCrimeData(int zipcode, string year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/getCrimeData", ReplyAction="http://tempuri.org/IService/getCrimeDataResponse")]
        System.Threading.Tasks.Task<string[]> getCrimeDataAsync(int zipcode, string year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/zipToState", ReplyAction="http://tempuri.org/IService/zipToStateResponse")]
        string zipToState(int zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/zipToState", ReplyAction="http://tempuri.org/IService/zipToStateResponse")]
        System.Threading.Tasks.Task<string> zipToStateAsync(int zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSolarData", ReplyAction="http://tempuri.org/IService/GetSolarDataResponse")]
        string GetSolarData(double lat, double lon, string month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSolarData", ReplyAction="http://tempuri.org/IService/GetSolarDataResponse")]
        System.Threading.Tasks.Task<string> GetSolarDataAsync(double lat, double lon, string month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/monthToInt", ReplyAction="http://tempuri.org/IService/monthToIntResponse")]
        int monthToInt(string month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/monthToInt", ReplyAction="http://tempuri.org/IService/monthToIntResponse")]
        System.Threading.Tasks.Task<int> monthToIntAsync(string month);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetWeatherData", ReplyAction="http://tempuri.org/IService/GetWeatherDataResponse")]
        string[] GetWeatherData(string month, double lat, double lon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetWeatherData", ReplyAction="http://tempuri.org/IService/GetWeatherDataResponse")]
        System.Threading.Tasks.Task<string[]> GetWeatherDataAsync(string month, double lat, double lon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConvertToIn", ReplyAction="http://tempuri.org/IService/ConvertToInResponse")]
        double ConvertToIn(double mm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConvertToIn", ReplyAction="http://tempuri.org/IService/ConvertToInResponse")]
        System.Threading.Tasks.Task<double> ConvertToInAsync(double mm);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : DefaultPage.WeatherService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<DefaultPage.WeatherService.IService>, DefaultPage.WeatherService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string findStore(string zip, string name) {
            return base.Channel.findStore(zip, name);
        }
        
        public System.Threading.Tasks.Task<string> findStoreAsync(string zip, string name) {
            return base.Channel.findStoreAsync(zip, name);
        }
        
        public string FindAddress(string s) {
            return base.Channel.FindAddress(s);
        }
        
        public System.Threading.Tasks.Task<string> FindAddressAsync(string s) {
            return base.Channel.FindAddressAsync(s);
        }
        
        public string[] getCrimeData(int zipcode, string year) {
            return base.Channel.getCrimeData(zipcode, year);
        }
        
        public System.Threading.Tasks.Task<string[]> getCrimeDataAsync(int zipcode, string year) {
            return base.Channel.getCrimeDataAsync(zipcode, year);
        }
        
        public string zipToState(int zip) {
            return base.Channel.zipToState(zip);
        }
        
        public System.Threading.Tasks.Task<string> zipToStateAsync(int zip) {
            return base.Channel.zipToStateAsync(zip);
        }
        
        public string GetSolarData(double lat, double lon, string month) {
            return base.Channel.GetSolarData(lat, lon, month);
        }
        
        public System.Threading.Tasks.Task<string> GetSolarDataAsync(double lat, double lon, string month) {
            return base.Channel.GetSolarDataAsync(lat, lon, month);
        }
        
        public int monthToInt(string month) {
            return base.Channel.monthToInt(month);
        }
        
        public System.Threading.Tasks.Task<int> monthToIntAsync(string month) {
            return base.Channel.monthToIntAsync(month);
        }
        
        public string[] GetWeatherData(string month, double lat, double lon) {
            return base.Channel.GetWeatherData(month, lat, lon);
        }
        
        public System.Threading.Tasks.Task<string[]> GetWeatherDataAsync(string month, double lat, double lon) {
            return base.Channel.GetWeatherDataAsync(month, lat, lon);
        }
        
        public double ConvertToIn(double mm) {
            return base.Channel.ConvertToIn(mm);
        }
        
        public System.Threading.Tasks.Task<double> ConvertToInAsync(double mm) {
            return base.Channel.ConvertToInAsync(mm);
        }
    }
}