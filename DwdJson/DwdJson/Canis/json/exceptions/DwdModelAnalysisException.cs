using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.json.exceptions
{
	// Token: 0x0200001C RID: 28
	public sealed class DwdModelAnalysisException : Exception
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00005ED4 File Offset: 0x000040D4
		// Note: this type is marked as 'beforefieldinit'.
		static DwdModelAnalysisException()
		{
			Il2CppClassPointerStore<DwdModelAnalysisException>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json.exceptions", "DwdModelAnalysisException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdModelAnalysisException>.NativeClassPtr);
			DwdModelAnalysisException.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalysisException>.NativeClassPtr, 100663410);
			DwdModelAnalysisException.NativeMethodInfoPtr__ctor_Public_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdModelAnalysisException>.NativeClassPtr, 100663411);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005F2C File Offset: 0x0000412C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249590, XrefRangeEnd = 1249598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdModelAnalysisException(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdModelAnalysisException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalysisException.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005F78 File Offset: 0x00004178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249598, XrefRangeEnd = 1249606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdModelAnalysisException(Type type, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdModelAnalysisException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdModelAnalysisException.NativeMethodInfoPtr__ctor_Public_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000025DD File Offset: 0x000007DD
		public DwdModelAnalysisException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_0;
	}
}
