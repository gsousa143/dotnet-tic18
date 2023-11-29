
Hospital h = new Hospital();

class Pessoa{
    protected String nome;
    protected DateTime dataDeNascimento;
    protected string cpf;
    public string Nome{
        get{
            return nome;
        }
        set{
            nome = value;
        }
    }
    public DateTime DataDeNascimento{get;set;}
    public string Cpf{
        get{
        return cpf;
        }set{
            if ((value.Length==11)||value.All(char.IsDigit))
                cpf = value;
            else
                throw new ArgumentException("CPF invalido");
            
        }
    }
}

class Medico : Pessoa{
    private string crm;
    public string Crm{get;set;}

}

class Paciente : Pessoa{
    private string sexo;
    public string Sexo{
        get{
            return sexo;
        }
        set{
            if((value.ToLower().Equals("masculino"))||(value.ToLower().Equals("feminino")))
                sexo = value;
            else
                throw new Exception("Sexo invalido");
        }
    }

    public string Sintomas{get;set;}



}

class Hospital{
    private List<Paciente> pacientes;
    private List<Medico> medicos;

    public List<Paciente> Pacientes{
        get{
            return pacientes;
        }
        set{
            pacientes = value;
        }
    }
    public List<Medico> Medicos{
        get{
            return medicos;
        }
        set{
            medicos = value;
        }
    }
    public Hospital(){
        pacientes = new List<Paciente>();
        medicos = new List<Medico>();
    }

    public void adicionaPaciente(Paciente novoPaciente){
        if(Pacientes.Any(x => x.Cpf == novoPaciente.Cpf))
            throw new ArgumentException("Paciente ja incluso na lista");
        else
            Pacientes.Add(novoPaciente);
    }
    public void adicionaMedico(Medico novoMedico){
        if(Medicos.Any(x => (x.Cpf == novoMedico.Cpf)||(x.Crm == novoMedico.Crm)))
            throw new ArgumentException("Medico ja incluso na lista");
        else
            Medicos.Add(novoMedico);
    }
    



}


