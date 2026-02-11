using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Configuration
{
	// Token: 0x02000007 RID: 7
	public sealed class ConfigurationCollectionAttribute : Attribute
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000020BE File Offset: 0x000002BE
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationCollectionAttribute()
		{
			Il2CppClassPointerStore<ConfigurationCollectionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationCollectionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationCollectionAttribute>.NativeClassPtr);
			ConfigurationCollectionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationCollectionAttribute>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000024D8 File Offset: 0x000006D8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationCollectionAttribute(Type itemType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationCollectionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationCollectionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020F7 File Offset: 0x000002F7
		public ConfigurationCollectionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
