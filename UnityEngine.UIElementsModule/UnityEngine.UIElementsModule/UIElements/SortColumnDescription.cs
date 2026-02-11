using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007B RID: 123
	[Serializable]
	public class SortColumnDescription : Object
	{
		// Token: 0x06000C52 RID: 3154 RVA: 0x00048888 File Offset: 0x00046A88
		// Note: this type is marked as 'beforefieldinit'.
		static SortColumnDescription()
		{
			Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "SortColumnDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr);
			SortColumnDescription.NativeFieldInfoPtr_m_ColumnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, "m_ColumnIndex");
			SortColumnDescription.NativeFieldInfoPtr_m_ColumnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, "m_ColumnName");
			SortColumnDescription.NativeFieldInfoPtr_m_SortDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, "m_SortDirection");
			SortColumnDescription.NativeFieldInfoPtr__column_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, "<column>k__BackingField");
			SortColumnDescription.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, "changed");
			SortColumnDescription.NativeMethodInfoPtr_get_columnName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665071);
			SortColumnDescription.NativeMethodInfoPtr_set_columnName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665072);
			SortColumnDescription.NativeMethodInfoPtr_get_columnIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665073);
			SortColumnDescription.NativeMethodInfoPtr_set_columnIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665074);
			SortColumnDescription.NativeMethodInfoPtr_get_column_Public_get_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665075);
			SortColumnDescription.NativeMethodInfoPtr_set_column_Internal_set_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665076);
			SortColumnDescription.NativeMethodInfoPtr_get_direction_Public_get_SortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665077);
			SortColumnDescription.NativeMethodInfoPtr_set_direction_Public_set_Void_SortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665078);
			SortColumnDescription.NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665079);
			SortColumnDescription.NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665080);
			SortColumnDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665081);
			SortColumnDescription.NativeMethodInfoPtr__ctor_Public_Void_Int32_SortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665082);
			SortColumnDescription.NativeMethodInfoPtr__ctor_Public_Void_String_SortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, 100665083);
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00048A20 File Offset: 0x00046C20
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00048A58 File Offset: 0x00046C58
		public unsafe string columnName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_get_columnName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302496, RefRangeEnd = 302497, XrefRangeStart = 302494, XrefRangeEnd = 302496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_set_columnName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00048A9C File Offset: 0x00046C9C
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x00048AD8 File Offset: 0x00046CD8
		public unsafe int columnIndex
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_get_columnIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302502, RefRangeEnd = 302503, XrefRangeStart = 302502, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_set_columnIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00048B18 File Offset: 0x00046D18
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00048B58 File Offset: 0x00046D58
		public unsafe Column column
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_get_column_Public_get_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Column>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_set_column_Internal_set_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00048B9C File Offset: 0x00046D9C
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00048BD8 File Offset: 0x00046DD8
		public unsafe SortDirection direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_get_direction_Public_get_SortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 302503, RefRangeEnd = 302505, XrefRangeStart = 302503, XrefRangeEnd = 302503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_set_direction_Public_set_Void_SortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00048C18 File Offset: 0x00046E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302505, XrefRangeEnd = 302510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_changed(Action<SortColumnDescription> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00048C5C File Offset: 0x00046E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302510, XrefRangeEnd = 302515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_changed(Action<SortColumnDescription> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00048CA0 File Offset: 0x00046EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302515, XrefRangeEnd = 302516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortColumnDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00048CDC File Offset: 0x00046EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302517, RefRangeEnd = 302518, XrefRangeStart = 302516, XrefRangeEnd = 302517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortColumnDescription(int columnIndex, SortDirection direction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref columnIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr__ctor_Public_Void_Int32_SortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00048D34 File Offset: 0x00046F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302521, RefRangeEnd = 302522, XrefRangeStart = 302518, XrefRangeEnd = 302521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortColumnDescription(string columnName, SortDirection direction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.NativeMethodInfoPtr__ctor_Public_Void_String_SortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00006911 File Offset: 0x00004B11
		public SortColumnDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00048D90 File Offset: 0x00046F90
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x0000691A File Offset: 0x00004B1A
		public unsafe int m_ColumnIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr_m_ColumnIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr_m_ColumnIndex)) = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00048DB8 File Offset: 0x00046FB8
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00006935 File Offset: 0x00004B35
		public unsafe string m_ColumnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr_m_ColumnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr_m_ColumnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00048DE0 File Offset: 0x00046FE0
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00006954 File Offset: 0x00004B54
		public unsafe SortDirection m_SortDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr_m_SortDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr_m_SortDirection)) = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00048E08 File Offset: 0x00047008
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x0000696F File Offset: 0x00004B6F
		public unsafe Column _column_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr__column_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Column>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr__column_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00048E38 File Offset: 0x00047038
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x0000698E File Offset: 0x00004B8E
		public unsafe Action<SortColumnDescription> changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr_changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SortColumnDescription>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnIndex;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnName;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeFieldInfoPtr_m_SortDirection;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeFieldInfoPtr__column_k__BackingField;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_get_columnName_Public_get_String_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_set_columnName_Public_set_Void_String_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_get_columnIndex_Public_get_Int32_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_set_columnIndex_Public_set_Void_Int32_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_get_column_Public_get_Column_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_set_column_Internal_set_Void_Column_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_SortDirection_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Public_set_Void_SortDirection_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_1_SortColumnDescription_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_1_SortColumnDescription_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_SortDirection_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SortDirection_0;

		// Token: 0x020003AB RID: 939
		public class UxmlObjectFactory<T> : UxmlObjectFactory<T, SortColumnDescription.UxmlObjectTraits<T>> where T : SortColumnDescription, new()
		{
			// Token: 0x060038FC RID: 14588 RVA: 0x000E7FB0 File Offset: 0x000E61B0
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectFactory()
			{
				Il2CppClassPointerStore<SortColumnDescription.UxmlObjectFactory<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, "UxmlObjectFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectFactory<T>>.NativeClassPtr);
				SortColumnDescription.UxmlObjectFactory<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectFactory<T>>.NativeClassPtr, 100665084);
			}

			// Token: 0x060038FD RID: 14589 RVA: 0x000E802C File Offset: 0x000E622C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 300055, RefRangeEnd = 300059, XrefRangeStart = 300055, XrefRangeEnd = 300059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectFactory<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.UxmlObjectFactory<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038FE RID: 14590 RVA: 0x00017D78 File Offset: 0x00015F78
			public UxmlObjectFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002868 RID: 10344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003AC RID: 940
		public class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : SortColumnDescription
		{
			// Token: 0x060038FF RID: 14591 RVA: 0x000E8068 File Offset: 0x000E6268
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectTraits()
			{
				Il2CppClassPointerStore<SortColumnDescription.UxmlObjectTraits<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortColumnDescription>.NativeClassPtr, "UxmlObjectTraits`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectTraits<T>>.NativeClassPtr);
				SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ColumnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectTraits<T>>.NativeClassPtr, "m_ColumnName");
				SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ColumnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectTraits<T>>.NativeClassPtr, "m_ColumnIndex");
				SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_SortDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectTraits<T>>.NativeClassPtr, "m_SortDescription");
				SortColumnDescription.UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectTraits<T>>.NativeClassPtr, 100665085);
				SortColumnDescription.UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectTraits<T>>.NativeClassPtr, 100665086);
			}

			// Token: 0x06003900 RID: 14592 RVA: 0x000E8134 File Offset: 0x000E6334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302460, XrefRangeEnd = 302464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortColumnDescription.UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x06003901 RID: 14593 RVA: 0x000E81C4 File Offset: 0x000E63C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302464, XrefRangeEnd = 302494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortColumnDescription.UxmlObjectTraits<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescription.UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003902 RID: 14594 RVA: 0x00017D81 File Offset: 0x00015F81
			public UxmlObjectTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700118A RID: 4490
			// (get) Token: 0x06003903 RID: 14595 RVA: 0x000E8200 File Offset: 0x000E6400
			// (set) Token: 0x06003904 RID: 14596 RVA: 0x00017D8A File Offset: 0x00015F8A
			public unsafe UxmlStringAttributeDescription m_ColumnName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ColumnName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ColumnName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700118B RID: 4491
			// (get) Token: 0x06003905 RID: 14597 RVA: 0x000E8230 File Offset: 0x000E6430
			// (set) Token: 0x06003906 RID: 14598 RVA: 0x00017DA9 File Offset: 0x00015FA9
			public unsafe UxmlIntAttributeDescription m_ColumnIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ColumnIndex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlIntAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ColumnIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700118C RID: 4492
			// (get) Token: 0x06003907 RID: 14599 RVA: 0x000E8260 File Offset: 0x000E6460
			// (set) Token: 0x06003908 RID: 14600 RVA: 0x00017DC8 File Offset: 0x00015FC8
			public unsafe UxmlEnumAttributeDescription<SortDirection> m_SortDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_SortDescription);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<SortDirection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescription.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_SortDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002869 RID: 10345
			private static readonly IntPtr NativeFieldInfoPtr_m_ColumnName;

			// Token: 0x0400286A RID: 10346
			private static readonly IntPtr NativeFieldInfoPtr_m_ColumnIndex;

			// Token: 0x0400286B RID: 10347
			private static readonly IntPtr NativeFieldInfoPtr_m_SortDescription;

			// Token: 0x0400286C RID: 10348
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0;

			// Token: 0x0400286D RID: 10349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
