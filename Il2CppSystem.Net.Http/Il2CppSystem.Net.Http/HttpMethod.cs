using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000010 RID: 16
	public class HttpMethod : Object
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00007730 File Offset: 0x00005930
		// Note: this type is marked as 'beforefieldinit'.
		static HttpMethod()
		{
			Il2CppClassPointerStore<HttpMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "HttpMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr);
			HttpMethod.NativeFieldInfoPtr_delete_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, "delete_method");
			HttpMethod.NativeFieldInfoPtr_get_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, "get_method");
			HttpMethod.NativeFieldInfoPtr_head_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, "head_method");
			HttpMethod.NativeFieldInfoPtr_options_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, "options_method");
			HttpMethod.NativeFieldInfoPtr_post_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, "post_method");
			HttpMethod.NativeFieldInfoPtr_put_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, "put_method");
			HttpMethod.NativeFieldInfoPtr_trace_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, "trace_method");
			HttpMethod.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, "method");
			HttpMethod.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663426);
			HttpMethod.NativeMethodInfoPtr_get_Get_Public_Static_get_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663427);
			HttpMethod.NativeMethodInfoPtr_get_Method_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663428);
			HttpMethod.NativeMethodInfoPtr_get_Post_Public_Static_get_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663429);
			HttpMethod.NativeMethodInfoPtr_get_Put_Public_Static_get_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663430);
			HttpMethod.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HttpMethod_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663431);
			HttpMethod.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HttpMethod_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663432);
			HttpMethod.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HttpMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663433);
			HttpMethod.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663434);
			HttpMethod.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663435);
			HttpMethod.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr, 100663436);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000078DC File Offset: 0x00005ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171759, RefRangeEnd = 1171760, XrefRangeStart = 1171749, XrefRangeEnd = 1171759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpMethod(string method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpMethod>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpMethod.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00007928 File Offset: 0x00005B28
		public unsafe static HttpMethod Get
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171760, XrefRangeEnd = 1171764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpMethod.NativeMethodInfoPtr_get_Get_Public_Static_get_HttpMethod_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr3) : null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000795C File Offset: 0x00005B5C
		public unsafe string Method
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpMethod.NativeMethodInfoPtr_get_Method_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00007994 File Offset: 0x00005B94
		public unsafe static HttpMethod Post
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171764, XrefRangeEnd = 1171768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpMethod.NativeMethodInfoPtr_get_Post_Public_Static_get_HttpMethod_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr3) : null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000079C8 File Offset: 0x00005BC8
		public unsafe static HttpMethod Put
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171768, XrefRangeEnd = 1171772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpMethod.NativeMethodInfoPtr_get_Put_Public_Static_get_HttpMethod_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr3) : null;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000079FC File Offset: 0x00005BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171772, XrefRangeEnd = 1171773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HttpMethod left, HttpMethod right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpMethod.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HttpMethod_HttpMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007A50 File Offset: 0x00005C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1171777, RefRangeEnd = 1171778, XrefRangeStart = 1171773, XrefRangeEnd = 1171777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HttpMethod left, HttpMethod right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpMethod.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HttpMethod_HttpMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007AA4 File Offset: 0x00005CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171778, XrefRangeEnd = 1171780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(HttpMethod other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpMethod.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HttpMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007AF4 File Offset: 0x00005CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171780, XrefRangeEnd = 1171784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpMethod.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007B4C File Offset: 0x00005D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpMethod.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007B94 File Offset: 0x00005D94
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HttpMethod.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000025B8 File Offset: 0x000007B8
		public HttpMethod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00007BD8 File Offset: 0x00005DD8
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000025C1 File Offset: 0x000007C1
		public unsafe static HttpMethod delete_method
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpMethod.NativeFieldInfoPtr_delete_method, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpMethod.NativeFieldInfoPtr_delete_method, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00007C00 File Offset: 0x00005E00
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000025D3 File Offset: 0x000007D3
		public unsafe static HttpMethod get_method
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpMethod.NativeFieldInfoPtr_get_method, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpMethod.NativeFieldInfoPtr_get_method, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00007C28 File Offset: 0x00005E28
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000025E5 File Offset: 0x000007E5
		public unsafe static HttpMethod head_method
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpMethod.NativeFieldInfoPtr_head_method, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpMethod.NativeFieldInfoPtr_head_method, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00007C50 File Offset: 0x00005E50
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000025F7 File Offset: 0x000007F7
		public unsafe static HttpMethod options_method
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpMethod.NativeFieldInfoPtr_options_method, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpMethod.NativeFieldInfoPtr_options_method, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00007C78 File Offset: 0x00005E78
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002609 File Offset: 0x00000809
		public unsafe static HttpMethod post_method
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpMethod.NativeFieldInfoPtr_post_method, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpMethod.NativeFieldInfoPtr_post_method, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00007CA0 File Offset: 0x00005EA0
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000261B File Offset: 0x0000081B
		public unsafe static HttpMethod put_method
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpMethod.NativeFieldInfoPtr_put_method, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpMethod.NativeFieldInfoPtr_put_method, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00007CC8 File Offset: 0x00005EC8
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000262D File Offset: 0x0000082D
		public unsafe static HttpMethod trace_method
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpMethod.NativeFieldInfoPtr_trace_method, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpMethod>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpMethod.NativeFieldInfoPtr_trace_method, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00007CF0 File Offset: 0x00005EF0
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000263F File Offset: 0x0000083F
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpMethod.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpMethod.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_delete_method;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_get_method;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_head_method;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_options_method;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_post_method;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_put_method;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_trace_method;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_get_Get_Public_Static_get_HttpMethod_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_String_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_get_Post_Public_Static_get_HttpMethod_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_get_Put_Public_Static_get_HttpMethod_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HttpMethod_HttpMethod_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HttpMethod_HttpMethod_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HttpMethod_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
