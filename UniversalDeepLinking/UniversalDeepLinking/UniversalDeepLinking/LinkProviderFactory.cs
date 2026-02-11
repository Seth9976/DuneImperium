using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking
{
	// Token: 0x02000010 RID: 16
	public class LinkProviderFactory : Object
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000053C8 File Offset: 0x000035C8
		// Note: this type is marked as 'beforefieldinit'.
		static LinkProviderFactory()
		{
			Il2CppClassPointerStore<LinkProviderFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking", "LinkProviderFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkProviderFactory>.NativeClassPtr);
			LinkProviderFactory.NativeFieldInfoPtr_DeferredExePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkProviderFactory>.NativeClassPtr, "DeferredExePath");
			LinkProviderFactory.NativeMethodInfoPtr_GetProvider_Public_ILinkProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderFactory>.NativeClassPtr, 100663430);
			LinkProviderFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkProviderFactory>.NativeClassPtr, 100663431);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005434 File Offset: 0x00003634
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILinkProvider GetProvider(bool isSteamBuild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSteamBuild;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkProviderFactory.NativeMethodInfoPtr_GetProvider_Public_ILinkProvider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILinkProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005480 File Offset: 0x00003680
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkProviderFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkProviderFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkProviderFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002437 File Offset: 0x00000637
		public LinkProviderFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000054BC File Offset: 0x000036BC
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002440 File Offset: 0x00000640
		public unsafe static string DeferredExePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LinkProviderFactory.NativeFieldInfoPtr_DeferredExePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LinkProviderFactory.NativeFieldInfoPtr_DeferredExePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_DeferredExePath;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_GetProvider_Public_ILinkProvider_Boolean_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
