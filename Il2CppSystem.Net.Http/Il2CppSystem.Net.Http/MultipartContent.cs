using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000014 RID: 20
	public class MultipartContent : HttpContent
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00008DC8 File Offset: 0x00006FC8
		// Note: this type is marked as 'beforefieldinit'.
		static MultipartContent()
		{
			Il2CppClassPointerStore<MultipartContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "MultipartContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr);
			MultipartContent.NativeFieldInfoPtr_nested_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, "nested_content");
			MultipartContent.NativeFieldInfoPtr_boundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, "boundary");
			MultipartContent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663474);
			MultipartContent.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663475);
			MultipartContent.NativeMethodInfoPtr_IsValidRFC2049_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663476);
			MultipartContent.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_HttpContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663477);
			MultipartContent.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663478);
			MultipartContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663479);
			MultipartContent.NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663480);
			MultipartContent.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_HttpContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663481);
			MultipartContent.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, 100663482);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008ED4 File Offset: 0x000070D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172215, RefRangeEnd = 1172216, XrefRangeStart = 1172206, XrefRangeEnd = 1172215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipartContent(string subtype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subtype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipartContent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00008F20 File Offset: 0x00007120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172280, RefRangeEnd = 1172281, XrefRangeStart = 1172216, XrefRangeEnd = 1172280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipartContent(string subtype, string boundary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subtype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(boundary);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipartContent.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00008F80 File Offset: 0x00007180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172281, XrefRangeEnd = 1172284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidRFC2049(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipartContent.NativeMethodInfoPtr_IsValidRFC2049_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008FC4 File Offset: 0x000071C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172284, XrefRangeEnd = 1172303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(HttpContent content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipartContent.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_HttpContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00009014 File Offset: 0x00007214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172303, XrefRangeEnd = 1172319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipartContent.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00009060 File Offset: 0x00007260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172319, XrefRangeEnd = 1172331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipartContent.NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000090D0 File Offset: 0x000072D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172331, XrefRangeEnd = 1172371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryComputeLength(out long length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipartContent.NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00009124 File Offset: 0x00007324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172371, XrefRangeEnd = 1172377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<HttpContent> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipartContent.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_HttpContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<HttpContent>>(intPtr3) : null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00009164 File Offset: 0x00007364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172377, XrefRangeEnd = 1172383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipartContent.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000283A File Offset: 0x00000A3A
		public MultipartContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000091A4 File Offset: 0x000073A4
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002843 File Offset: 0x00000A43
		public unsafe List<HttpContent> nested_content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent.NativeFieldInfoPtr_nested_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HttpContent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent.NativeFieldInfoPtr_nested_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000091D4 File Offset: 0x000073D4
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002862 File Offset: 0x00000A62
		public unsafe string boundary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent.NativeFieldInfoPtr_boundary);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent.NativeFieldInfoPtr_boundary), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_nested_content;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_boundary;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_IsValidRFC2049_Private_Static_Boolean_String_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_HttpContent_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_SerializeToStreamAsync_Protected_Virtual_Task_Stream_TransportContext_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_TryComputeLength_FamOrAssem_Virtual_Boolean_byref_Int64_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_HttpContent_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("System.Net.Http.MultipartContent+<SerializeToStreamAsync>d__8")]
		public sealed class _SerializeToStreamAsync_d__8 : ValueType
		{
			// Token: 0x0600046F RID: 1135 RVA: 0x00015994 File Offset: 0x00013B94
			// Note: this type is marked as 'beforefieldinit'.
			static _SerializeToStreamAsync_d__8()
			{
				Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MultipartContent>.NativeClassPtr, "<SerializeToStreamAsync>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr);
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "<>1__state");
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "<>t__builder");
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "<>4__this");
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "stream");
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "context");
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__sb_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "<sb>5__2");
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "<i>5__3");
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__c_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "<c>5__4");
				MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, "<>u__1");
				MultipartContent._SerializeToStreamAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, 100663483);
				MultipartContent._SerializeToStreamAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr, 100663484);
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x00015A9C File Offset: 0x00013C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172098, XrefRangeEnd = 1172202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipartContent._SerializeToStreamAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00015AD4 File Offset: 0x00013CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172202, XrefRangeEnd = 1172206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipartContent._SerializeToStreamAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x00003DB0 File Offset: 0x00001FB0
			public _SerializeToStreamAsync_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000473 RID: 1139 RVA: 0x00003DB9 File Offset: 0x00001FB9
			public _SerializeToStreamAsync_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipartContent._SerializeToStreamAsync_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x00015B1C File Offset: 0x00013D1C
			// (set) Token: 0x06000475 RID: 1141 RVA: 0x00003DCB File Offset: 0x00001FCB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x00015B44 File Offset: 0x00013D44
			// (set) Token: 0x06000477 RID: 1143 RVA: 0x00003DE6 File Offset: 0x00001FE6
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x00015B74 File Offset: 0x00013D74
			// (set) Token: 0x06000479 RID: 1145 RVA: 0x00003E14 File Offset: 0x00002014
			public unsafe MultipartContent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipartContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x0600047A RID: 1146 RVA: 0x00015BA4 File Offset: 0x00013DA4
			// (set) Token: 0x0600047B RID: 1147 RVA: 0x00003E33 File Offset: 0x00002033
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x00015BD4 File Offset: 0x00013DD4
			// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003E52 File Offset: 0x00002052
			public unsafe TransportContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransportContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x00015C04 File Offset: 0x00013E04
			// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003E71 File Offset: 0x00002071
			public unsafe StringBuilder _sb_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__sb_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__sb_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x00015C34 File Offset: 0x00013E34
			// (set) Token: 0x06000481 RID: 1153 RVA: 0x00003E90 File Offset: 0x00002090
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x00015C5C File Offset: 0x00013E5C
			// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003EAB File Offset: 0x000020AB
			public unsafe HttpContent _c_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__c_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpContent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr__c_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x00015C8C File Offset: 0x00013E8C
			// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003ECA File Offset: 0x000020CA
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultipartContent._SerializeToStreamAsync_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000320 RID: 800
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000321 RID: 801
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000322 RID: 802
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000323 RID: 803
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04000324 RID: 804
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04000325 RID: 805
			private static readonly IntPtr NativeFieldInfoPtr__sb_5__2;

			// Token: 0x04000326 RID: 806
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04000327 RID: 807
			private static readonly IntPtr NativeFieldInfoPtr__c_5__4;

			// Token: 0x04000328 RID: 808
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000329 RID: 809
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400032A RID: 810
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
