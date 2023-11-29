
Listas hospital = new Listas();





class virtual Pessoa{
    private String nome;
    private DateTime dataDeNascimento;
    private string cpf;
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
            sexo = value;
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

    adicionaPaciente(Paciente novoPaciente){
        if(Pacientes.Contains(x => x.Cpf == novoPaciente.Cpf))
            throw new ArgumentException("Paciente ja incluso na lista");
        else
            Pacientes.Add(novoPaciente);
    }
    adicionaMedico(Medico novoMedico){
        if(Medicos.Contains(x => (x.Cpf == novoPaciente.Cpf)||(x.Crm == novoMedico.Crm)))
            throw new ArgumentException("Medico ja incluso na lista");
        else
            Pacientes.Add(novoPaciente);
    }
}



