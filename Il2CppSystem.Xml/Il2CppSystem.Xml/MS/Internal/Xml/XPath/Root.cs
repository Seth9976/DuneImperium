using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000205 RID: 517
	public class Root : AstNode
	{
		// Token: 0x06002D5A RID: 11610 RVA: 0x000D0B70 File Offset: 0x000CED70
		// Note: this type is marked as 'beforefieldinit'.
		static Root()
		{
			Il2CppClassPointerStore<Root>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Root");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Root>.NativeClassPtr);
			Root.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Root>.NativeClassPtr, 100669844);
			Root.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Root>.NativeClassPtr, 100669845);
			Root.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Root>.NativeClassPtr, 100669846);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000D0BDC File Offset: 0x000CEDDC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Root()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Root>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Root.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000D0C18 File Offset: 0x000CEE18
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Root.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x000D0C60 File Offset: 0x000CEE60
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Root.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00012B92 File Offset: 0x00010D92
		public Root(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;
	}
}
