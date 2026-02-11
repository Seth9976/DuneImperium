using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using JsonFx.Serialization;

namespace JsonFx.Model
{
	// Token: 0x02000024 RID: 36
	public class ModelWriter : DataWriter
	{
		// Token: 0x060001BC RID: 444 RVA: 0x0000A240 File Offset: 0x00008440
		// Note: this type is marked as 'beforefieldinit'.
		static ModelWriter()
		{
			Il2CppClassPointerStore<ModelWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Model", "ModelWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModelWriter>.NativeClassPtr);
			ModelWriter.NativeMethodInfoPtr__ctor_Protected_Void_DataWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWriter>.NativeClassPtr, 100663535);
			ModelWriter.NativeMethodInfoPtr_get_ContentEncoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWriter>.NativeClassPtr, 100663536);
			ModelWriter.NativeMethodInfoPtr_GetWalker_Protected_Virtual_IObjectWalker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModelWriter>.NativeClassPtr, 100663537);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000A2AC File Offset: 0x000084AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModelWriter(DataWriterSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModelWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModelWriter.NativeMethodInfoPtr__ctor_Protected_Void_DataWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public unsafe override Encoding ContentEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192169, XrefRangeEnd = 1192170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModelWriter.NativeMethodInfoPtr_get_ContentEncoding_Public_Virtual_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000A344 File Offset: 0x00008544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192170, XrefRangeEnd = 1192175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IObjectWalker GetWalker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModelWriter.NativeMethodInfoPtr_GetWalker_Protected_Virtual_IObjectWalker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IObjectWalker>(intPtr3) : null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002B1A File Offset: 0x00000D1A
		public ModelWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DataWriterSettings_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentEncoding_Public_Virtual_get_Encoding_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_GetWalker_Protected_Virtual_IObjectWalker_0;
	}
}
