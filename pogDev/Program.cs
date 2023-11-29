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

}

class Paciente : Pessoa{
        private char sexo;
    public char Sexo{
        get{
            return sexo;
        }
        set{
            sexo = value;
        }
    }
    public string Sintomas{get;set;}
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



