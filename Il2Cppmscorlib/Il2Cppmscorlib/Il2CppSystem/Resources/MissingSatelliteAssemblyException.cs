using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003E4 RID: 996
	[Serializable]
	public class MissingSatelliteAssemblyException : SystemException
	{
		// Token: 0x06003A63 RID: 14947 RVA: 0x00119824 File Offset: 0x00117A24
		// Note: this type is marked as 'beforefieldinit'.
		static MissingSatelliteAssemblyException()
		{
			Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "MissingSatelliteAssemblyException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr);
			MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, "_cultureName");
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100672018);
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100672019);
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100672020);
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x001198A4 File Offset: 0x00117AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396465, XrefRangeEnd = 1396468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x001198E0 File Offset: 0x00117AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1396470, RefRangeEnd = 1396471, XrefRangeStart = 1396468, XrefRangeEnd = 1396470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException(string message, string cultureName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x00119940 File Offset: 0x00117B40
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x00015AD5 File Offset: 0x00013CD5
		public MissingSatelliteAssemblyException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x001199A4 File Offset: 0x00117BA4
		// (set) Token: 0x06003A69 RID: 14953 RVA: 0x00015ADE File Offset: 0x00013CDE
		public unsafe string _cultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002F44 RID: 12100
		private static readonly IntPtr NativeFieldInfoPtr__cultureName;

		// Token: 0x04002F45 RID: 12101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F46 RID: 12102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04002F47 RID: 12103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
