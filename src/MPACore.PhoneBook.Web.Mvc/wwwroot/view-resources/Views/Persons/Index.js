﻿
(function () {

    $(function () {
        var _personService = abp.services.app.person;

        var _$modal = $("#PersonCreateModal");
        var _$form = _$modal.find('form');

        //添加联系人功能
        _$form.find('button[type="submit"]').click(function (e) {
            debugger;
            e.preventDefault;
            if (!_$form.valid()) {
                return;
            }
            var personEditDto = _$form.serializeFormToObject();//序列化表单对象
            abp.ui.setBusy(_$modal);
            _personService.createOrUpdatePerson({ personEditDto }).done(function() {
                _$modal.modal('hide');
                location.reload();
            }).always(function() {
                abp.ui.clearBusy(_$modal);
            });
            
        });
    });
        
})();