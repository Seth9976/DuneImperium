using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000374 RID: 884
	public sealed class InternalFE : Object
	{
		// Token: 0x06003715 RID: 14101 RVA: 0x0010E5F0 File Offset: 0x0010C7F0
		// Note: this type is marked as 'beforefieldinit'.
		static InternalFE()
		{
			Il2CppClassPointerStore<InternalFE>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "InternalFE");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalFE>.NativeClassPtr);
			InternalFE.NativeFieldInfoPtr_FEtypeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEtypeFormat");
			InternalFE.NativeFieldInfoPtr_FEassemblyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEassemblyFormat");
			InternalFE.NativeFieldInfoPtr_FEsecurityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEsecurityLevel");
			InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEserializerTypeEnum");
			InternalFE.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, 100671586);
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x0010E684 File Offset: 0x0010C884
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalFE()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalFE>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalFE.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x0001409A File Offset: 0x0001229A
		public InternalFE(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x0010E6C0 File Offset: 0x0010C8C0
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x000140A3 File Offset: 0x000122A3
		public unsafe FormatterTypeStyle FEtypeFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEtypeFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEtypeFormat)) = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x0010E6E8 File Offset: 0x0010C8E8
		// (set) Token: 0x0600371B RID: 14107 RVA: 0x000140BE File Offset: 0x000122BE
		public unsafe FormatterAssemblyStyle FEassemblyFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEassemblyFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEassemblyFormat)) = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x0010E710 File Offset: 0x0010C910
		// (set) Token: 0x0600371D RID: 14109 RVA: 0x000140D9 File Offset: 0x000122D9
		public unsafe TypeFilterLevel FEsecurityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEsecurityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEsecurityLevel)) = value;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x0010E738 File Offset: 0x0010C938
		// (set) Token: 0x0600371F RID: 14111 RVA: 0x000140F4 File Offset: 0x000122F4
		public unsafe InternalSerializerTypeE FEserializerTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalFE.NativeFieldInfoPtr_FEserializerTypeEnum)) = value;
			}
		}

		// Token: 0x04002CC1 RID: 11457
		private static readonly IntPtr NativeFieldInfoPtr_FEtypeFormat;

		// Token: 0x04002CC2 RID: 11458
		private static readonly IntPtr NativeFieldInfoPtr_FEassemblyFormat;

		// Token: 0x04002CC3 RID: 11459
		private static readonly IntPtr NativeFieldInfoPtr_FEsecurityLevel;

		// Token: 0x04002CC4 RID: 11460
		private static readonly IntPtr NativeFieldInfoPtr_FEserializerTypeEnum;

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
