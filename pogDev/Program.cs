
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

    public Pessoa(string nome, string cpf, string dataDeNascimento){
        this.nome = nome;
        if ((cpf.Length==11)||cpf.All(char.IsDigit))
                this.cpf = cpf;
            else
                throw new ArgumentException("CPF invalido");
        this.dataDeNascimento = DateTime.Parse(dataDeNascimento);
    }
}

class Medico : Pessoa{
    private string crm;
    public string Crm{get;set;}
        public Medico(string nome,string cpf,string dataDeNascimento,string crm){
        this.nome = nome;
        this.cpf = cpf;
        this.crm = crm;
        
    }
}

class Paciente : Pessoa{
    private string sexo;
    private string sintomas;
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
    public string Sintomas{
        get{
            return sintomas;
        }
        set{
            sintomas = value;
        }
    }


    public Paciente(string nome,string cpf,string dataDeNascimento,string sexo,string sintomas){
        
        this.sintomas = sintomas;
        if((sexo.Equals("masculino"))||(sexo.Equals("feminino")))
            this.sexo = sexo;
        else
            throw new Exception("Sexo invalido");
    }

}

class Hospital{
    private List<Paciente> pacientes;
    private List<Medico> medicos;
    private List<Pessoa> pessoas;

    public List<Pessoa> Pessoas{
        get{
            return pessoas;
        }
        set{
            pessoas = value;
        }
    }

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
        pessoas = new List<Pessoa>();
    }

    public void adicionaPaciente(Paciente novoPaciente){
        if(Pacientes.Any(x => x.Cpf == novoPaciente.Cpf))
            throw new ArgumentException("Paciente ja incluso na lista");
        else
            Pacientes.Add(novoPaciente);
            Pessoas.Add(novoPaciente);
    }
    public void adicionaMedico(Medico novoMedico){
        if(Medicos.Any(x => (x.Cpf == novoMedico.Cpf)||(x.Crm == novoMedico.Crm)))
            throw new ArgumentException("Medico ja incluso na lista");
        else
            Medicos.Add(novoMedico);
            Pessoas.Add(novoMedico);
    }


    public void MedicosIdade(int idadeInf,int idadeSup){
        List<Medico> relatorio = new List<Medico>();
        relatorio = Medicos.Where(x => (DateTime.Now.Year-x.DataDeNascimento.Year>idadeInf)&&(DateTime.Now.Year-x.DataDeNascimento.Year>idadeSup)).ToList();
        foreach(Medico medico in relatorio){
            Console.WriteLine($"Nome: {medico.Nome}, CRM: {medico.Crm}");
        }
    }

    public void PacienteIdade(int idadeInf,int idadeSup){
        List<Paciente> relatorio = new List<Paciente>();
        relatorio = Pacientes.Where(x => (DateTime.Now.Year-x.DataDeNascimento.Year>idadeInf)&&(DateTime.Now.Year-x.DataDeNascimento.Year>idadeSup)).ToList();
        foreach(Paciente paciente in relatorio){
            Console.WriteLine($"Nome: {paciente.Nome}, CPF: {paciente.Cpf}");
        }
    }
}


