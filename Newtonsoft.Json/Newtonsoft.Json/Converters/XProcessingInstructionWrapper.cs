using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FB RID: 251
	public class XProcessingInstructionWrapper : XObjectWrapper
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x00071E8C File Offset: 0x0007008C
		// Note: this type is marked as 'beforefieldinit'.
		static XProcessingInstructionWrapper()
		{
			Il2CppClassPointerStore<XProcessingInstructionWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XProcessingInstructionWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XProcessingInstructionWrapper>.NativeClassPtr);
			XProcessingInstructionWrapper.NativeMethodInfoPtr_get_ProcessingInstruction_Private_get_XProcessingInstruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstructionWrapper>.NativeClassPtr, 100667260);
			XProcessingInstructionWrapper.NativeMethodInfoPtr__ctor_Public_Void_XProcessingInstruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstructionWrapper>.NativeClassPtr, 100667261);
			XProcessingInstructionWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstructionWrapper>.NativeClassPtr, 100667262);
			XProcessingInstructionWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstructionWrapper>.NativeClassPtr, 100667263);
			XProcessingInstructionWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstructionWrapper>.NativeClassPtr, 100667264);
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00071F20 File Offset: 0x00070120
		public unsafe XProcessingInstruction ProcessingInstruction
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765466, XrefRangeEnd = 765468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XProcessingInstructionWrapper.NativeMethodInfoPtr_get_ProcessingInstruction_Private_get_XProcessingInstruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XProcessingInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00071F60 File Offset: 0x00070160
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XProcessingInstructionWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processingInstruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XProcessingInstructionWrapper.NativeMethodInfoPtr__ctor_Public_Void_XProcessingInstruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00071FAC File Offset: 0x000701AC
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765468, XrefRangeEnd = 765470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XProcessingInstructionWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x00071FF0 File Offset: 0x000701F0
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x00072034 File Offset: 0x00070234
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765470, XrefRangeEnd = 765472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XProcessingInstructionWrapper.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765472, XrefRangeEnd = 765479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XProcessingInstructionWrapper.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0000846E File Offset: 0x0000666E
		public XProcessingInstructionWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessingInstruction_Private_get_XProcessingInstruction_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XProcessingInstruction_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;
	}
}
