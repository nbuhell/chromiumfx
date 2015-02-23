// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


// cef_print_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_print_handler_t {
    cef_print_handler_t cef_print_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_print_handler_t;

int CEF_CALLBACK _cfx_print_handler_add_ref(struct _cef_base_t* base) {
    cfx_print_handler_t* ptr = (cfx_print_handler_t*)base;
    return InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_print_handler_release(struct _cef_base_t* base) {
    cfx_print_handler_t* ptr = (cfx_print_handler_t*)base;
    int count = InterlockedDecrement(&((cfx_print_handler_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_print_handler_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}
int CEF_CALLBACK _cfx_print_handler_get_refct(struct _cef_base_t* base) {
    cfx_print_handler_t* ptr = (cfx_print_handler_t*)base;
    return ptr->ref_count;
}

CFX_EXPORT cfx_print_handler_t* cfx_print_handler_ctor(gc_handle_t gc_handle) {
    cfx_print_handler_t* ptr = (cfx_print_handler_t*)calloc(1, sizeof(cfx_print_handler_t));
    if(!ptr) return 0;
    ptr->cef_print_handler.base.size = sizeof(cef_print_handler_t);
    ptr->cef_print_handler.base.add_ref = _cfx_print_handler_add_ref;
    ptr->cef_print_handler.base.release = _cfx_print_handler_release;
    ptr->cef_print_handler.base.get_refct = _cfx_print_handler_get_refct;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_print_handler_get_gc_handle(cfx_print_handler_t* self) {
    return self->gc_handle;
}

// on_print_settings

void (CEF_CALLBACK *cfx_print_handler_on_print_settings_callback)(gc_handle_t self, cef_print_settings_t* settings, int get_defaults);

void CEF_CALLBACK cfx_print_handler_on_print_settings(cef_print_handler_t* self, cef_print_settings_t* settings, int get_defaults) {
    cfx_print_handler_on_print_settings_callback(((cfx_print_handler_t*)self)->gc_handle, settings, get_defaults);
}


// on_print_dialog

void (CEF_CALLBACK *cfx_print_handler_on_print_dialog_callback)(gc_handle_t self, int* __retval, int has_selection, cef_print_dialog_callback_t* callback);

int CEF_CALLBACK cfx_print_handler_on_print_dialog(cef_print_handler_t* self, int has_selection, cef_print_dialog_callback_t* callback) {
    int __retval;
    cfx_print_handler_on_print_dialog_callback(((cfx_print_handler_t*)self)->gc_handle, &__retval, has_selection, callback);
    return __retval;
}


// on_print_job

void (CEF_CALLBACK *cfx_print_handler_on_print_job_callback)(gc_handle_t self, int* __retval, char16 *document_name_str, int document_name_length, char16 *pdf_file_path_str, int pdf_file_path_length, cef_print_job_callback_t* callback);

int CEF_CALLBACK cfx_print_handler_on_print_job(cef_print_handler_t* self, const cef_string_t* document_name, const cef_string_t* pdf_file_path, cef_print_job_callback_t* callback) {
    int __retval;
    cfx_print_handler_on_print_job_callback(((cfx_print_handler_t*)self)->gc_handle, &__retval, document_name ? document_name->str : 0, document_name ? document_name->length : 0, pdf_file_path ? pdf_file_path->str : 0, pdf_file_path ? pdf_file_path->length : 0, callback);
    return __retval;
}


// on_print_reset

void (CEF_CALLBACK *cfx_print_handler_on_print_reset_callback)(gc_handle_t self);

void CEF_CALLBACK cfx_print_handler_on_print_reset(cef_print_handler_t* self) {
    cfx_print_handler_on_print_reset_callback(((cfx_print_handler_t*)self)->gc_handle);
}


CFX_EXPORT void cfx_print_handler_activate_callback(cef_print_handler_t* self, int index, int is_active) {
    switch(index) {
    case 0:
        self->on_print_settings = is_active ? cfx_print_handler_on_print_settings : 0;
        break;
    case 1:
        self->on_print_dialog = is_active ? cfx_print_handler_on_print_dialog : 0;
        break;
    case 2:
        self->on_print_job = is_active ? cfx_print_handler_on_print_job : 0;
        break;
    case 3:
        self->on_print_reset = is_active ? cfx_print_handler_on_print_reset : 0;
        break;
    }
}
CFX_EXPORT void cfx_print_handler_set_callback_ptrs(void *cb_0, void *cb_1, void *cb_2, void *cb_3) {
    cfx_print_handler_on_print_settings_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_print_settings_t* settings, int get_defaults)) cb_0;
    cfx_print_handler_on_print_dialog_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, int has_selection, cef_print_dialog_callback_t* callback)) cb_1;
    cfx_print_handler_on_print_job_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, char16 *document_name_str, int document_name_length, char16 *pdf_file_path_str, int pdf_file_path_length, cef_print_job_callback_t* callback)) cb_2;
    cfx_print_handler_on_print_reset_callback = (void (CEF_CALLBACK *)(gc_handle_t self)) cb_3;
}

#ifdef __cplusplus
} // extern "C"
#endif

