using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000139 RID: 313
	public sealed class EnumData : ValueType
	{
		// Token: 0x0600182A RID: 6186 RVA: 0x00071CD0 File Offset: 0x0006FED0
		// Note: this type is marked as 'beforefieldinit'.
		static EnumData()
		{
			Il2CppClassPointerStore<EnumData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "EnumData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumData>.NativeClassPtr);
			EnumData.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "values");
			EnumData.NativeFieldInfoPtr_flagValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "flagValues");
			EnumData.NativeFieldInfoPtr_displayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "displayNames");
			EnumData.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "names");
			EnumData.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "tooltip");
			EnumData.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "flags");
			EnumData.NativeFieldInfoPtr_underlyingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "underlyingType");
			EnumData.NativeFieldInfoPtr_unsigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "unsigned");
			EnumData.NativeFieldInfoPtr_serializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "serializable");
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000098E8 File Offset: 0x00007AE8
		public EnumData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000098F1 File Offset: 0x00007AF1
		public EnumData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumData>.NativeClassPtr))
		{
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00071DB4 File Offset: 0x0006FFB4
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x00009903 File Offset: 0x00007B03
		public unsafe Il2CppStructArray<Enum> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Enum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00071DE4 File Offset: 0x0006FFE4
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x00009922 File Offset: 0x00007B22
		public unsafe Il2CppStructArray<int> flagValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flagValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flagValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00071E14 File Offset: 0x00070014
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x00009941 File Offset: 0x00007B41
		public unsafe Il2CppStringArray displayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_displayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_displayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00071E44 File Offset: 0x00070044
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00009960 File Offset: 0x00007B60
		public unsafe Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00071E74 File Offset: 0x00070074
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0000997F File Offset: 0x00007B7F
		public unsafe Il2CppStringArray tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_tooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_tooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00071EA4 File Offset: 0x000700A4
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000999E File Offset: 0x00007B9E
		public unsafe bool flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00071ECC File Offset: 0x000700CC
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x000099B9 File Offset: 0x00007BB9
		public unsafe Type underlyingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_underlyingType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_underlyingType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00071EFC File Offset: 0x000700FC
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x000099D8 File Offset: 0x00007BD8
		public unsafe bool unsigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_unsigned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_unsigned)) = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00071F24 File Offset: 0x00070124
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x000099F3 File Offset: 0x00007BF3
		public unsafe bool serializable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_serializable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_serializable)) = value;
			}
		}

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeFieldInfoPtr_flagValues;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeFieldInfoPtr_displayNames;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeFieldInfoPtr_underlyingType;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeFieldInfoPtr_unsigned;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeFieldInfoPtr_serializable;
	}
}
