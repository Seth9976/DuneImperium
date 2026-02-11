using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using zen.src.preferences;

namespace worm.utils
{
	// Token: 0x0200005D RID: 93
	public sealed class WormDefaultConfigValues : DefaultConfigValues
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x000249F0 File Offset: 0x00022BF0
		// Note: this type is marked as 'beforefieldinit'.
		static WormDefaultConfigValues()
		{
			Il2CppClassPointerStore<WormDefaultConfigValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.utils", "WormDefaultConfigValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDefaultConfigValues>.NativeClassPtr);
			WormDefaultConfigValues.NativeMethodInfoPtr_getString_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDefaultConfigValues>.NativeClassPtr, 100663911);
			WormDefaultConfigValues.NativeMethodInfoPtr_getBool_Protected_Virtual_Nullable_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDefaultConfigValues>.NativeClassPtr, 100663912);
			WormDefaultConfigValues.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDefaultConfigValues>.NativeClassPtr, 100663913);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00024A5C File Offset: 0x00022C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693590, XrefRangeEnd = 693640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string getString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDefaultConfigValues.NativeMethodInfoPtr_getString_Protected_Virtual_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00024AA4 File Offset: 0x00022CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693640, XrefRangeEnd = 693647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<bool> getBool(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDefaultConfigValues.NativeMethodInfoPtr_getBool_Protected_Virtual_Nullable_1_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00024AEC File Offset: 0x00022CEC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDefaultConfigValues()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDefaultConfigValues>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDefaultConfigValues.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00003A14 File Offset: 0x00001C14
		public WormDefaultConfigValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_getString_Protected_Virtual_String_String_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_getBool_Protected_Virtual_Nullable_1_Boolean_String_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
