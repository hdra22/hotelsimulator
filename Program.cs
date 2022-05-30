using HotelCSharp.Exceptions;
using HotelCSharp.Interfaces;
using HotelCSharp.Models;

Console.WriteLine("*****************************************");
Console.WriteLine("*************** Hotel CSharp*************");
Console.WriteLine("*****************************************");
Console.WriteLine();

//Contratar funcionaria 
IFuncionaria funcionaria01 = new Funcionaria("Joana Almeida", 263789456, "912315678");
IFuncionaria funcionaria02 = new Funcionaria("Rita Jorge", 263747456, "912124612");

//Contratar rececionista
IRececionista rececionista01 = new Rececionista()
{
    Nome = "Mariana Silva",
    NIF = 258585968,
    Telemovel = "936585895"
};
IRececionista rececionista02 = new Rececionista("João Matos", 258585968, "932145678");

//Contratar gerente
//Administrou 10 hoteis e está empregado
IGerente gerente01 = new Gerente("Manuela Alves", 256365898, "921456369");
//Administrou 2 hoteis e está desempregado
IGerente gerente02 = new Gerente("Joao Cunha", 585968898, "912347103");

//Inauguração do Hotel
var hotel = new Hotel("Hotel CSharp", new Morada()
{
    Rua = "Rua dos Magalhães", 
    Numero = 25, 
    Freguesia = "Lordelo", 
    Concelho = "Porto", 
    Distrito = "Porto"
});

//Contratar Funcionaria
hotel.ContratarFuncionaria(funcionaria01);
hotel.ContratarFuncionaria(funcionaria02);

//Contratar Rececionista
hotel.ContratarRececionista(rececionista01);
hotel.ContratarRececionista(rececionista02);


//Contratar Gerente
hotel.ContratarGerente(gerente01);

//Contratar o faz tudo
hotel.ContratarFuncionaria(gerente02);
hotel.ContratarRececionista(gerente02);

//Gerente
hotel.Gerente.ApresentarSe();
hotel.Gerente.FazerACama();
hotel.Gerente.LimparOQuarto();
hotel.Gerente.AtenderOTelefone();
hotel.Gerente.FalarOBasicoDeIngles();

foreach (var funcionaria in hotel.Funcionarias)
{
    funcionaria.ApresentarSe();
    funcionaria.FazerACama();
    funcionaria.LimparOQuarto();
}

foreach (var rececionista in hotel.Rececionistas)
{
    rececionista.ApresentarSe();
    rececionista.AtenderOTelefone();
    rececionista.FalarOBasicoDeIngles();
}

//A partir daqui será tudo da responsabilidade do RH
System.Console.WriteLine();
IRHTerceirizado rh = new RH("RH CShap", hotel);

//Contratar uma funcionaria
var funcionaria03 = new Funcionaria
{
    Nome = "Eugenia Ferreira"
};
rh.ContratarFuncionaria(funcionaria03);

//Contratar uma rececionista
var rececionista03 = new Rececionista("Mariana Correia", 256256256,"912385274");
rh.ContratarRececionista(rececionista03);


//Promover uma funcionaria
var funcionariaASerPromovida = new Funcionaria{
    Nome = "Rita Alves"
};

try
{
    rh.PromoverParaGerente(funcionariaASerPromovida);
}
catch (DocumentosInvalidosException ex)
{
     System.Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    //Se cair aqui é porque o sistema "quebrou" 
    System.Console.WriteLine(ex.Message);
}


//Promover uma rececionista
var rececionistaASerPromovida = new Rececionista{
    Nome = "Amanda Teixeira",
    NIF = 55895895
};
try
{
    rh.PromoverParaGerente(rececionistaASerPromovida);
}
catch (DocumentosInvalidosException ex)
{
     System.Console.WriteLine(ex.Message);
}


System.Console.WriteLine();