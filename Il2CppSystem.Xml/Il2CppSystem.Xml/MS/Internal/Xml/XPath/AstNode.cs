using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x020001FE RID: 510
	public class AstNode : Object
	{
		// Token: 0x06002D00 RID: 11520 RVA: 0x000CF840 File Offset: 0x000CDA40
		// Note: this type is marked as 'beforefieldinit'.
		static AstNode()
		{
			Il2CppClassPointerStore<AstNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "AstNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstNode>.NativeClassPtr);
			AstNode.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100669808);
			AstNode.NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100669809);
			AstNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstNode>.NativeClassPtr, 100669810);
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x000CF8AC File Offset: 0x000CDAAC
		public unsafe virtual AstNode.AstType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AstNode.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000CF8F4 File Offset: 0x000CDAF4
		public unsafe virtual XPathResultType ReturnType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AstNode.NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000CF93C File Offset: 0x000CDB3C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000128FA File Offset: 0x00010AFA
		public AstNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_AstType_0;

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Abstract_Virtual_New_get_XPathResultType_0;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000280 RID: 640
		public enum AstType
		{
			// Token: 0x040027E6 RID: 10214
			Axis,
			// Token: 0x040027E7 RID: 10215
			Operator,
			// Token: 0x040027E8 RID: 10216
			Filter,
			// Token: 0x040027E9 RID: 10217
			ConstantOperand,
			// Token: 0x040027EA RID: 10218
			Function,
			// Token: 0x040027EB RID: 10219
			Group,
			// Token: 0x040027EC RID: 10220
			Root,
			// Token: 0x040027ED RID: 10221
			Variable,
			// Token: 0x040027EE RID: 10222
			Error
		}
	}
}
