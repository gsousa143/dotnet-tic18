
Listas hospital = new Listas();

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
            cpf = value;
        }
    }
}

class Medico : Pessoa{
    private string crm;
    public string Crm{
        get{
            return crm;
        }
        set{
            crm = value;
        }
    }

    public Medico(string nome,DateTime dataDeNascimento, string cpf, string crm){
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
        this.crm = crm;
    }

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

    public Paciente(string nome,DateTime dataDeNascimento, string cpf, string sexo, string sintomas){
        this.nome = nome;
        this.dataDeNascimento = dataDeNascimento;
        this.cpf = cpf;
        this.sexo = sexo;
        this.Sintomas = sintomas; 
    }
}

class Listas{
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
    public Listas(){
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


