using BansLibraryApi.Data;
using BansLibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BansLibraryApi.Services;

public class ContactService
{
    private readonly AppDbContext _db;

    public ContactService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Contact>> GetContactsAsync()
    {
        var records = await _db.Contacts.ToListAsync();
        return records != null! ? records : new List<Contact>();
    }

    public async Task<List<Contact>> GetContactsByStudentIdAsync(Guid? id)
    {
        if (id == Guid.Empty || id == null!)
        {
            return new List<Contact>();
        }

        var records = await _db.Contacts
            .Where(c => c.StudentId == id).ToListAsync();
        return records != null! ? records : new List<Contact>();
    }

    public async Task<Contact> GetContactByIdAsync(Guid? id)
    {
        if (id == Guid.Empty || id == null!)
        {
            return null!;
        }

        var record = await _db.Contacts.FindAsync(id);
        return record != null! ? record : null!;
    }

    public async Task<Contact> GetContactByStudentIdAsync(Guid? id)
    {
        if (id == Guid.Empty || id == null!)
        {
            return null!;
        }

        var record = await _db.Contacts
            .FirstOrDefaultAsync(c => c.StudentId == id);
        return record != null! ? record : null!;
    }

    public async Task<Contact> CreateContactAsync(Contact contact)
    {
        if (contact == null!)
        {
            return null!;
        }

        var record = await _db.Contacts.AddAsync(contact);
        var result = await _db.SaveChangesAsync();
        return result > 0 ? record.Entity : null!;
    }

    public async Task<Contact> UpdateContactAsync(Contact contact)
    {
        if (contact == null!)
        {
            return null!;
        }

        var record = await _db.Contacts.FindAsync(contact.Id);
        if (record == null!)
        {
            return null!;
        }

        record.Content = contact.Content;
        record.IsActive = contact.IsActive;
        record.StudentId = contact.StudentId;
        var result = await _db.SaveChangesAsync();
        return result > 0 ? record : null!;
    }

    public async Task<bool> DeleteContactAsync(Guid? id)
    {
        if (id == Guid.Empty || id == null!)
        {
            return false;
        }

        var record = await _db.Contacts.FindAsync(id);
        if (record == null!)
        {
            return false;
        }

        _db.Contacts.Remove(record);
        var result = await _db.SaveChangesAsync();
        return result > 0;
    }

    public async Task<bool> DeleteContactByStudentIdAsync(Guid? id)
    {
        if (id == Guid.Empty || id == null!)
        {
            return false;
        }

        var record = await _db.Contacts
            .Where(c => c.StudentId == id).ToListAsync();
        if (record == null!)
        {
            return false;
        }

        _db.Contacts.RemoveRange(record);
        var result = await _db.SaveChangesAsync();
        return result > 0;
    }

    public async Task<bool> ContactExistsAsync(Contact contact)
    {
        if (contact == null!)
        {
            return false;
        }

        return await _db.Contacts
            .AnyAsync(c => c.Content == contact.Content && c.StudentId == contact.StudentId);
    }
}
