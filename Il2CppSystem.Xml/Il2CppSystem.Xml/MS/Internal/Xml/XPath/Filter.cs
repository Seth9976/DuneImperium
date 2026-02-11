using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000200 RID: 512
	public class Filter : AstNode
	{
		// Token: 0x06002D22 RID: 11554 RVA: 0x000CFFF4 File Offset: 0x000CE1F4
		// Note: this type is marked as 'beforefieldinit'.
		static Filter()
		{
			Il2CppClassPointerStore<Filter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Filter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Filter>.NativeClassPtr);
			Filter.NativeFieldInfoPtr__input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Filter>.NativeClassPtr, "_input");
			Filter.NativeFieldInfoPtr__condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Filter>.NativeClassPtr, "_condition");
			Filter.NativeMethodInfoPtr__ctor_Public_Void_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Filter>.NativeClassPtr, 100669824);
			Filter.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Filter>.NativeClassPtr, 100669825);
			Filter.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Filter>.NativeClassPtr, 100669826);
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000D0088 File Offset: 0x000CE288
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Filter(AstNode input, AstNode condition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Filter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(condition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Filter.NativeMethodInfoPtr__ctor_Public_Void_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x000D00E8 File Offset: 0x000CE2E8
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Filter.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002D25 RID: 11557 RVA: 0x000D0130 File Offset: 0x000CE330
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Filter.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x000129D9 File Offset: 0x00010BD9
		public Filter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000D0178 File Offset: 0x000CE378
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x000129E2 File Offset: 0x00010BE2
		public unsafe AstNode _input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Filter.NativeFieldInfoPtr__input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Filter.NativeFieldInfoPtr__input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000D01A8 File Offset: 0x000CE3A8
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x00012A01 File Offset: 0x00010C01
		public unsafe AstNode _condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Filter.NativeFieldInfoPtr__condition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Filter.NativeFieldInfoPtr__condition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeFieldInfoPtr__input;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeFieldInfoPtr__condition;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AstNode_AstNode_0;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;
	}
}
