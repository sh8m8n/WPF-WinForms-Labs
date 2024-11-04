namespace BusinessLogic.DTOs
{
    /// <summary>
    /// Служит для создания и чтения DTO
    /// </summary>
    /// <typeparam name="T">Target type</typeparam>
    /// <typeparam name="K">DTO type</typeparam>
    public interface IDTOAssembler<T, K>
    {
        K Create(T entity);
    }
}
