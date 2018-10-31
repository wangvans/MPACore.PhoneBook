using MPACore.PhoneBook.PhoneBooks.Persons;
using MPACore.PhoneBook.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.AutoMapper;
using MPACore.PhoneBook.PhoneBooks.Dtos;

namespace MPACore.PhoneBook.PhoneBooks.PhoneNumber.Dto
{
    [AutoMapTo(typeof(PhoneBooks.PhoneNumbers.PhoneNumber))]
    public class PhoneNumberEditDto
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxPhoneNumberLength)]
        public string Number { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PhoneNumberType Type { get; set; }

    }
}
