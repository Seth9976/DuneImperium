using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200001D RID: 29
	public class XText : XNode
	{
		// Token: 0x0600015C RID: 348 RVA: 0x0000845C File Offset: 0x0000665C
		// Note: this type is marked as 'beforefieldinit'.
		static XText()
		{
			Il2CppClassPointerStore<XText>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XText>.NativeClassPtr);
			XText.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XText>.NativeClassPtr, "text");
			XText.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XText>.NativeClassPtr, 100663531);
			XText.NativeMethodInfoPtr__ctor_Public_Void_XText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XText>.NativeClassPtr, 100663532);
			XText.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XText>.NativeClassPtr, 100663533);
			XText.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XText>.NativeClassPtr, 100663534);
			XText.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XText>.NativeClassPtr, 100663535);
			XText.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XText>.NativeClassPtr, 100663536);
			XText.NativeMethodInfoPtr_AppendText_Internal_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XText>.NativeClassPtr, 100663537);
			XText.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XText>.NativeClassPtr, 100663538);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00008540 File Offset: 0x00006740
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1236992, RefRangeEnd = 1236996, XrefRangeStart = 1236992, XrefRangeEnd = 1236996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XText(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XText>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XText.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000858C File Offset: 0x0000678C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XText(XText other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XText>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XText.NativeMethodInfoPtr__ctor_Public_Void_XText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000085D8 File Offset: 0x000067D8
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XText.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00008620 File Offset: 0x00006820
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00008658 File Offset: 0x00006858
		public unsafe string Value
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XText.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238628, RefRangeEnd = 1238629, XrefRangeStart = 1238618, XrefRangeEnd = 1238628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XText.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000869C File Offset: 0x0000689C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238629, XrefRangeEnd = 1238637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteTo(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XText.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000086EC File Offset: 0x000068EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238637, XrefRangeEnd = 1238639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AppendText(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XText.NativeMethodInfoPtr_AppendText_Internal_Virtual_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000873C File Offset: 0x0000693C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238639, XrefRangeEnd = 1238644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XNode CloneNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XText.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr3) : null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002734 File Offset: 0x00000934
		public XText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00008788 File Offset: 0x00006988
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000273D File Offset: 0x0000093D
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XText.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XText.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XText_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_AppendText_Internal_Virtual_Void_StringBuilder_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0;
	}
}
