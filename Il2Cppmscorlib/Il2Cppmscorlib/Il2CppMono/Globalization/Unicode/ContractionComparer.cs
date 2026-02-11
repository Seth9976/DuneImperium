using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000022 RID: 34
	public class ContractionComparer : Object
	{
		// Token: 0x06000109 RID: 265 RVA: 0x000293A4 File Offset: 0x000275A4
		// Note: this type is marked as 'beforefieldinit'.
		static ContractionComparer()
		{
			Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "ContractionComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr);
			ContractionComparer.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr, "Instance");
			ContractionComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Contraction_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr, 100663490);
			ContractionComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr, 100663491);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00029410 File Offset: 0x00027610
		[CallerCount(0)]
		public unsafe virtual int Compare(Contraction c1, Contraction c2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractionComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Contraction_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00029470 File Offset: 0x00027670
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractionComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractionComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000273C File Offset: 0x0000093C
		public ContractionComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000294AC File Offset: 0x000276AC
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002745 File Offset: 0x00000945
		public unsafe static ContractionComparer Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContractionComparer.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractionComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContractionComparer.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Contraction_Contraction_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
