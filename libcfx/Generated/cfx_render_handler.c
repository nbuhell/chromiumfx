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


// cef_render_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_render_handler_t {
    cef_render_handler_t cef_render_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_render_handler_t;

int CEF_CALLBACK _cfx_render_handler_add_ref(struct _cef_base_t* base) {
    cfx_render_handler_t* ptr = (cfx_render_handler_t*)base;
    return InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_render_handler_release(struct _cef_base_t* base) {
    cfx_render_handler_t* ptr = (cfx_render_handler_t*)base;
    int count = InterlockedDecrement(&((cfx_render_handler_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_render_handler_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}
int CEF_CALLBACK _cfx_render_handler_get_refct(struct _cef_base_t* base) {
    cfx_render_handler_t* ptr = (cfx_render_handler_t*)base;
    return ptr->ref_count;
}

CFX_EXPORT cfx_render_handler_t* cfx_render_handler_ctor(gc_handle_t gc_handle) {
    cfx_render_handler_t* ptr = (cfx_render_handler_t*)calloc(1, sizeof(cfx_render_handler_t));
    if(!ptr) return 0;
    ptr->cef_render_handler.base.size = sizeof(cef_render_handler_t);
    ptr->cef_render_handler.base.add_ref = _cfx_render_handler_add_ref;
    ptr->cef_render_handler.base.release = _cfx_render_handler_release;
    ptr->cef_render_handler.base.get_refct = _cfx_render_handler_get_refct;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_render_handler_get_gc_handle(cfx_render_handler_t* self) {
    return self->gc_handle;
}

// get_root_screen_rect

void (CEF_CALLBACK *cfx_render_handler_get_root_screen_rect_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_rect_t* rect);

int CEF_CALLBACK cfx_render_handler_get_root_screen_rect(cef_render_handler_t* self, cef_browser_t* browser, cef_rect_t* rect) {
    int __retval;
    cfx_render_handler_get_root_screen_rect_callback(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, rect);
    return __retval;
}


// get_view_rect

void (CEF_CALLBACK *cfx_render_handler_get_view_rect_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_rect_t* rect);

int CEF_CALLBACK cfx_render_handler_get_view_rect(cef_render_handler_t* self, cef_browser_t* browser, cef_rect_t* rect) {
    int __retval;
    cfx_render_handler_get_view_rect_callback(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, rect);
    return __retval;
}


// get_screen_point

void (CEF_CALLBACK *cfx_render_handler_get_screen_point_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, int viewX, int viewY, int* screenX, int* screenY);

int CEF_CALLBACK cfx_render_handler_get_screen_point(cef_render_handler_t* self, cef_browser_t* browser, int viewX, int viewY, int* screenX, int* screenY) {
    int __retval;
    cfx_render_handler_get_screen_point_callback(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, viewX, viewY, screenX, screenY);
    return __retval;
}


// get_screen_info

void (CEF_CALLBACK *cfx_render_handler_get_screen_info_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_screen_info_t* screen_info);

int CEF_CALLBACK cfx_render_handler_get_screen_info(cef_render_handler_t* self, cef_browser_t* browser, cef_screen_info_t* screen_info) {
    int __retval;
    cfx_render_handler_get_screen_info_callback(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, screen_info);
    return __retval;
}


// on_popup_show

void (CEF_CALLBACK *cfx_render_handler_on_popup_show_callback)(gc_handle_t self, cef_browser_t* browser, int show);

void CEF_CALLBACK cfx_render_handler_on_popup_show(cef_render_handler_t* self, cef_browser_t* browser, int show) {
    cfx_render_handler_on_popup_show_callback(((cfx_render_handler_t*)self)->gc_handle, browser, show);
}


// on_popup_size

void (CEF_CALLBACK *cfx_render_handler_on_popup_size_callback)(gc_handle_t self, cef_browser_t* browser, const cef_rect_t* rect);

void CEF_CALLBACK cfx_render_handler_on_popup_size(cef_render_handler_t* self, cef_browser_t* browser, const cef_rect_t* rect) {
    cfx_render_handler_on_popup_size_callback(((cfx_render_handler_t*)self)->gc_handle, browser, rect);
}


// on_paint

void (CEF_CALLBACK *cfx_render_handler_on_paint_callback)(gc_handle_t self, cef_browser_t* browser, cef_paint_element_type_t type, int dirtyRectsCount, cef_rect_t const* dirtyRects, const void* buffer, int width, int height);

void CEF_CALLBACK cfx_render_handler_on_paint(cef_render_handler_t* self, cef_browser_t* browser, cef_paint_element_type_t type, size_t dirtyRectsCount, cef_rect_t const* dirtyRects, const void* buffer, int width, int height) {
    cfx_render_handler_on_paint_callback(((cfx_render_handler_t*)self)->gc_handle, browser, type, (int)(dirtyRectsCount), dirtyRects, buffer, width, height);
}


// on_cursor_change

void (CEF_CALLBACK *cfx_render_handler_on_cursor_change_callback)(gc_handle_t self, cef_browser_t* browser, cef_cursor_handle_t cursor, cef_cursor_type_t type, const cef_cursor_info_t* custom_cursor_info);

void CEF_CALLBACK cfx_render_handler_on_cursor_change(cef_render_handler_t* self, cef_browser_t* browser, cef_cursor_handle_t cursor, cef_cursor_type_t type, const cef_cursor_info_t* custom_cursor_info) {
    cfx_render_handler_on_cursor_change_callback(((cfx_render_handler_t*)self)->gc_handle, browser, cursor, type, custom_cursor_info);
}


// start_dragging

void (CEF_CALLBACK *cfx_render_handler_start_dragging_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_drag_data_t* drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y);

int CEF_CALLBACK cfx_render_handler_start_dragging(cef_render_handler_t* self, cef_browser_t* browser, cef_drag_data_t* drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y) {
    int __retval;
    cfx_render_handler_start_dragging_callback(((cfx_render_handler_t*)self)->gc_handle, &__retval, browser, drag_data, allowed_ops, x, y);
    return __retval;
}


// update_drag_cursor

void (CEF_CALLBACK *cfx_render_handler_update_drag_cursor_callback)(gc_handle_t self, cef_browser_t* browser, cef_drag_operations_mask_t operation);

void CEF_CALLBACK cfx_render_handler_update_drag_cursor(cef_render_handler_t* self, cef_browser_t* browser, cef_drag_operations_mask_t operation) {
    cfx_render_handler_update_drag_cursor_callback(((cfx_render_handler_t*)self)->gc_handle, browser, operation);
}


// on_scroll_offset_changed

void (CEF_CALLBACK *cfx_render_handler_on_scroll_offset_changed_callback)(gc_handle_t self, cef_browser_t* browser);

void CEF_CALLBACK cfx_render_handler_on_scroll_offset_changed(cef_render_handler_t* self, cef_browser_t* browser) {
    cfx_render_handler_on_scroll_offset_changed_callback(((cfx_render_handler_t*)self)->gc_handle, browser);
}


CFX_EXPORT void cfx_render_handler_activate_callback(cef_render_handler_t* self, int index, int is_active) {
    switch(index) {
    case 0:
        self->get_root_screen_rect = is_active ? cfx_render_handler_get_root_screen_rect : 0;
        break;
    case 1:
        self->get_view_rect = is_active ? cfx_render_handler_get_view_rect : 0;
        break;
    case 2:
        self->get_screen_point = is_active ? cfx_render_handler_get_screen_point : 0;
        break;
    case 3:
        self->get_screen_info = is_active ? cfx_render_handler_get_screen_info : 0;
        break;
    case 4:
        self->on_popup_show = is_active ? cfx_render_handler_on_popup_show : 0;
        break;
    case 5:
        self->on_popup_size = is_active ? cfx_render_handler_on_popup_size : 0;
        break;
    case 6:
        self->on_paint = is_active ? cfx_render_handler_on_paint : 0;
        break;
    case 7:
        self->on_cursor_change = is_active ? cfx_render_handler_on_cursor_change : 0;
        break;
    case 8:
        self->start_dragging = is_active ? cfx_render_handler_start_dragging : 0;
        break;
    case 9:
        self->update_drag_cursor = is_active ? cfx_render_handler_update_drag_cursor : 0;
        break;
    case 10:
        self->on_scroll_offset_changed = is_active ? cfx_render_handler_on_scroll_offset_changed : 0;
        break;
    }
}
CFX_EXPORT void cfx_render_handler_set_callback_ptrs(void *cb_0, void *cb_1, void *cb_2, void *cb_3, void *cb_4, void *cb_5, void *cb_6, void *cb_7, void *cb_8, void *cb_9, void *cb_10) {
    cfx_render_handler_get_root_screen_rect_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_rect_t* rect)) cb_0;
    cfx_render_handler_get_view_rect_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_rect_t* rect)) cb_1;
    cfx_render_handler_get_screen_point_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, int viewX, int viewY, int* screenX, int* screenY)) cb_2;
    cfx_render_handler_get_screen_info_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_screen_info_t* screen_info)) cb_3;
    cfx_render_handler_on_popup_show_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int show)) cb_4;
    cfx_render_handler_on_popup_size_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, const cef_rect_t* rect)) cb_5;
    cfx_render_handler_on_paint_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_paint_element_type_t type, int dirtyRectsCount, cef_rect_t const* dirtyRects, const void* buffer, int width, int height)) cb_6;
    cfx_render_handler_on_cursor_change_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_cursor_handle_t cursor, cef_cursor_type_t type, const cef_cursor_info_t* custom_cursor_info)) cb_7;
    cfx_render_handler_start_dragging_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_drag_data_t* drag_data, cef_drag_operations_mask_t allowed_ops, int x, int y)) cb_8;
    cfx_render_handler_update_drag_cursor_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, cef_drag_operations_mask_t operation)) cb_9;
    cfx_render_handler_on_scroll_offset_changed_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser)) cb_10;
}

#ifdef __cplusplus
} // extern "C"
#endif

