
Personel p = new Personel();

// Property'leri 1. partial'a
p.Ad="Deneme";

// metotları ise 2. partial'a yazdık 

p.Calis();

// Dosya her ne kadar fiziksel olarak ayrı dosyalar olsa da, partial ifadesi, iki dosyanın aslında
// tek bir dosya gibi davranmasını sağlar!!
// partial bir class'ın farklı fiziksel parçalar olarak yazabilmemizi sağlar
// ancak tabiki çalıştırma zamanında nesne üzerinden eriştiğimizde, bu iki parça halinde olan
// dosyalar birleşerek, tek bir dosya gibi davranır!!

//Partial Class : aslında kod yazarken bize kolaylık olsun, sıfına ait üyeler farklı fiziksel dosyalarda bulunsun diye vardır!!!
