using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000074 RID: 116
	public class DefaultNamingStrategy : NamingStrategy
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x00040F60 File Offset: 0x0003F160
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultNamingStrategy()
		{
			Il2CppClassPointerStore<DefaultNamingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "DefaultNamingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultNamingStrategy>.NativeClassPtr);
			DefaultNamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultNamingStrategy>.NativeClassPtr, 100665247);
			DefaultNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultNamingStrategy>.NativeClassPtr, 100665248);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00040FB8 File Offset: 0x0003F1B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ResolvePropertyName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultNamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0004100C File Offset: 0x0003F20C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultNamingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultNamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00005099 File Offset: 0x00003299
		public DefaultNamingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
