#region

using System.Diagnostics.CodeAnalysis;

#endregion

[assembly:
    SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type",
        Target = "MaxMind.GeoIP2.Model.MaxMind")]
[assembly:
    SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member",
        Target = "MaxMind.GeoIP2.Model.NamedEntity.#Locales")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member",
        Target = "MaxMind.GeoIP2.Model.RepresentedCountry.#Type")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "2#", Scope = "member",
        Target = "MaxMind.GeoIP2.WebServiceClient.#.ctor(System.Int32,System.String,System.String,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1058:TypesShouldNotExtendCertainBaseTypes", Scope = "type",
        Target = "MaxMind.GeoIP2.Exceptions.GeoIP2Exception")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "MaxMind.GeoIP2.Responses.AbstractCityResponse.#Subdivisions")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.DatabaseReader.#AnonymousIP(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.DatabaseReader.#ConnectionType(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.DatabaseReader.#Domain(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Isp", Scope = "member", Target = "MaxMind.GeoIP2.DatabaseReader.#Isp(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.DatabaseReader.#Isp(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "MaxMind.GeoIP2.Exceptions.HttpException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "MaxMind.GeoIP2.Exceptions.InvalidRequestException")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2DatabaseReader.#AnonymousIP(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2DatabaseReader.#ConnectionType(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2DatabaseReader.#Domain(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Isp", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2DatabaseReader.#Isp(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2DatabaseReader.#Isp(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2Provider.#Country(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2Provider.#Country(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2Provider.#City(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2Provider.#City(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2WebServicesClient.#Insights(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2WebServicesClient.#Insights(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2WebServicesClient.#CountryAsync(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2WebServicesClient.#CountryAsync(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2WebServicesClient.#CityAsync(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2WebServicesClient.#CityAsync(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2WebServicesClient.#InsightsAsync(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.IGeoIP2WebServicesClient.#InsightsAsync(System.Net.IPAddress)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "iso", Scope = "member", Target = "MaxMind.GeoIP2.Model.Country.#.ctor(System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>,System.String,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.Collections.Generic.IEnumerable`1<System.String>)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iso", Scope = "member", Target = "MaxMind.GeoIP2.Model.Country.#IsoCode")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "iso", Scope = "member", Target = "MaxMind.GeoIP2.Model.RepresentedCountry.#.ctor(System.String,System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>,System.String,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.Collections.Generic.IEnumerable`1<System.String>)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "iso", Scope = "member", Target = "MaxMind.GeoIP2.Model.Subdivision.#.ctor(System.Nullable`1<System.Int32>,System.Nullable`1<System.Int32>,System.String,System.Collections.Generic.IDictionary`2<System.String,System.String>,System.Collections.Generic.IEnumerable`1<System.String>)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iso", Scope = "member", Target = "MaxMind.GeoIP2.Model.Subdivision.#IsoCode")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ip", Scope = "member", Target = "MaxMind.GeoIP2.Model.Traits.#.ctor(System.Nullable`1<System.Int32>,System.String,System.String,System.String,System.Boolean,System.Boolean,System.String,System.String,System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "isp", Scope = "member", Target = "MaxMind.GeoIP2.Model.Traits.#.ctor(System.Nullable`1<System.Int32>,System.String,System.String,System.String,System.Boolean,System.Boolean,System.String,System.String,System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Isp", Scope = "member", Target = "MaxMind.GeoIP2.Model.Traits.#Isp")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Vpn", Scope = "member", Target = "MaxMind.GeoIP2.Responses.AnonymousIPResponse.#IsAnonymousVpn")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Isp", Scope = "type", Target = "MaxMind.GeoIP2.Responses.IspResponse")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Isp", Scope = "member", Target = "MaxMind.GeoIP2.Responses.IspResponse.#Isp")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "MaxMind.GeoIP2.Exceptions.AddressNotFoundException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "MaxMind.GeoIP2.Exceptions.AuthenticationException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "MaxMind.GeoIP2.Exceptions.GeoIP2Exception")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "MaxMind.GeoIP2.Exceptions.OutOfQueriesException")]