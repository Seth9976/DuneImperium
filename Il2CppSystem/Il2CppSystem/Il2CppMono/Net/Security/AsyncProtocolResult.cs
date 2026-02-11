using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.ExceptionServices;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000013 RID: 19
	public class AsyncProtocolResult : Object
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x0001DACC File Offset: 0x0001BCCC
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncProtocolResult()
		{
			Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "AsyncProtocolResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr);
			AsyncProtocolResult.NativeFieldInfoPtr__UserResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, "<UserResult>k__BackingField");
			AsyncProtocolResult.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, "<Error>k__BackingField");
			AsyncProtocolResult.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, 100663472);
			AsyncProtocolResult.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, 100663473);
			AsyncProtocolResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, 100663474);
			AsyncProtocolResult.NativeMethodInfoPtr__ctor_Public_Void_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr, 100663475);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0001DB74 File Offset: 0x0001BD74
		public unsafe int UserResult
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolResult.NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		public unsafe ExceptionDispatchInfo Error
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolResult.NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001DBF0 File Offset: 0x0001BDF0
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncProtocolResult(int result)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001DC38 File Offset: 0x0001BE38
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncProtocolResult(ExceptionDispatchInfo error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncProtocolResult>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncProtocolResult.NativeMethodInfoPtr__ctor_Public_Void_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002544 File Offset: 0x00000744
		public AsyncProtocolResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0001DC84 File Offset: 0x0001BE84
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000254D File Offset: 0x0000074D
		public unsafe int _UserResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolResult.NativeFieldInfoPtr__UserResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolResult.NativeFieldInfoPtr__UserResult_k__BackingField)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0001DCAC File Offset: 0x0001BEAC
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002568 File Offset: 0x00000768
		public unsafe ExceptionDispatchInfo _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolResult.NativeFieldInfoPtr__Error_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncProtocolResult.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr__UserResult_k__BackingField;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_UserResult_Public_get_Int32_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_ExceptionDispatchInfo_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExceptionDispatchInfo_0;
	}
}
