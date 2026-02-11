using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200019A RID: 410
	public sealed class SemanticMeaning : ValueType
	{
		// Token: 0x06001E89 RID: 7817 RVA: 0x000895C8 File Offset: 0x000877C8
		// Note: this type is marked as 'beforefieldinit'.
		static SemanticMeaning()
		{
			Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "SemanticMeaning");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr);
			SemanticMeaning.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, "key");
			SemanticMeaning.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, "values");
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0000B889 File Offset: 0x00009A89
		public SemanticMeaning(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0000B892 File Offset: 0x00009A92
		public SemanticMeaning()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr))
		{
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x00089620 File Offset: 0x00087820
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x0000B8A4 File Offset: 0x00009AA4
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00089648 File Offset: 0x00087848
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0000B8C3 File Offset: 0x00009AC3
		public unsafe Il2CppStringArray values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeFieldInfoPtr_values;
	}
}
