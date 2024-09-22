public class ELF64FileHeader{
    
    /// <summary>
    /// e_ident[0~3]: 0x7F, 'E', 'L', 'F'
    /// e_ident[4]:1 for 32bit, 2 for 64bit
    /// e_ident[5]:1 for little endian, 2 for big endian
    /// e_ident[6]:1 for original version
    /// e_ident[7~15]:padding
    /// </summary>
    public byte[] e_ident = new byte[16];
    /// <summary>
    /// e_type: 0 for ET_NONE, 1 for ET_REL, relocatable, 2 for ET_EXEC, executable, 3 for ET_DYN, shared, 4 for ET_CORE, core
    /// </summary>
    public ushort e_type;
    /// <summary>
    /// e_machine: 0 for EM_NONE, 0x03 for EM_386, 0x3E for EM_X86_64, 0x28 for EM_ARM, 0xB7 for EM_AARCH64
    /// </summary>
    public ushort e_machine;
    /// <summary>
    /// e_version: 1 for original version
    /// </summary>
    public uint e_version;
    /// <summary>
    /// e_entry: entry point, virtual memory address
    /// </summary>
    public ulong e_entry;
    /// <summary>
    /// e_phoff: the 1st program header table offset from the beginning of the file(a ELF file may have multiple program headers), 0 means no program header table
    /// </summary>
    public ulong e_phoff;
    /// <summary>
    /// e_shoff: the 1st section header table offset from the beginning of the file(a ELF file may have multiple section headers), 0 means no section header table
    /// </summary>
    public ulong e_shoff;
    /// <summary>
    /// e_flags: depends on e_machine, 0 for no flags, if e_machine is EM_ARM(0x28), e_flags is EF_ARM_HASENTRY(0x2)
    /// </summary>
    public uint e_flags;
    /// <summary>
    /// e_ehsize: ELF header size in bytes, 64 for 64bit, 52 for 32bit
    /// </summary>
    public ushort e_ehsize;
    /// <summary>
    /// e_phentsize: size of a program header table entry in bytes, 64 for 64bit, 56 for 32bit
    /// </summary>
    public ushort e_phentsize;
    /// <summary>
    /// e_phnum: number of entries in the program header table, 0 means no program header table
    /// </summary>
    public ushort e_phnum;
    /// <summary>
    /// e_shentsize: size of a section header table entry in bytes, 64 for 64bit, 40 for 32bit
    /// </summary>
    public ushort e_shentsize;
    /// <summary>
    /// e_shnum: number of entries in the section header table, 0 means no section header table
    /// </summary>
    public ushort e_shnum;
    /// <summary>
    /// e_shstrndx: the section header table index of the section name string table, 0 means no section name string table
    /// </summary>
    public ushort e_shstrndx;
}

public class ELF32FileHeader{
    public byte[] e_ident = new byte[16];
    public ushort e_type;
    public ushort e_machine;
    public uint e_version;
    public uint e_entry;
    public uint e_phoff;
    public uint e_shoff;
    public uint e_flags;
    public ushort e_ehsize;
    public ushort e_phentsize;
    public ushort e_phnum;
    public ushort e_shentsize;
    public ushort e_shnum;
    public ushort e_shstrndx;
}

public class ELF64SectionHeader{
    /// <summary>
    /// sh_name: the section name, an index into the section header string table
    /// </summary>
    public uint sh_name;
    /// <summary>
    /// sh_type: 0 for SHT_NULL, 1 for SHT_PROGBITS, 2 for SHT_SYMTAB, 3 for SHT_STRTAB, 4 for SHT_RELA, 5 for SHT_HASH, 6 for SHT_DYNAMIC, 7 for SHT_NOTE, 8 for SHT_NOBITS, 9 for SHT_REL, 10 for SHT_SHLIB, 11 for SHT_DYNSYM
    /// </summary>
    public uint sh_type;
    /// <summary>
    /// sh_flags: 0 for no flags
    /// </summary>
    public ulong sh_flags;
    /// <summary>
    /// sh_addr: the virtual memory address of the section
    /// </summary>
    public ulong sh_addr;
    /// <summary>
    /// sh_offset: the offset of the section in the file
    /// </summary>
    public ulong sh_offset;
    /// <summary>
    /// sh_size: the size of the section in bytes
    /// </summary>
    public ulong sh_size;
    /// <summary>
    /// sh_link: the section header table index link, whose interpretation depends on the section type
    /// </summary>
    public uint sh_link;
    /// <summary>
    /// sh_info: extra information about the section
    /// </summary>
    public uint sh_info;
    /// <summary>
    /// sh_addralign: the required alignment of the section
    /// </summary>
    public ulong sh_addralign;
    /// <summary>
    /// sh_entsize: the size of each entry in the section, 0 if the section does not have fixed-size entries
    /// </summary>
    public ulong sh_entsize;
}


public class ELF
{
    private string filename;



    public ELF(string filename)
    {
        this.filename = filename;
    }

    public void PrintHeader()
    {
        // Implementation for printing ELF header
        
    }

    public void PrintSections()
    {
        // Implementation for printing section headers
    }

    public void PrintProgramHeaders()
    {
        // Implementation for printing program headers
    }

    public void PrintDynamicSection()
    {
        // Implementation for printing dynamic section
    }

    public void PrintSymbolTable()
    {
        // Implementation for printing symbol table
    }
}
