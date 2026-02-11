using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001F4 RID: 500
	public class UpdateDictAttribute<T, U> : Action
	{
		// Token: 0x06001533 RID: 5427 RVA: 0x0006EEA8 File Offset: 0x0006D0A8
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateDictAttribute()
		{
			Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "UpdateDictAttribute`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr);
			UpdateDictAttribute<T, U>.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, "attribute");
			UpdateDictAttribute<T, U>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, "key");
			UpdateDictAttribute<T, U>.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, "defaultValue");
			UpdateDictAttribute<T, U>.NativeFieldInfoPtr_valueUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, "valueUpdate");
			UpdateDictAttribute<T, U>.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Dictionary_2_T_U_T_Func_1_U_Func_2_U_U_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, 100668046);
			UpdateDictAttribute<T, U>.NativeMethodInfoPtr_SetAtKey_Public_Static_UpdateDictAttribute_2_T_U_AttributeDefinition_1_Dictionary_2_T_U_T_U_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, 100668047);
			UpdateDictAttribute<T, U>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, 100668048);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0006EFB4 File Offset: 0x0006D1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590764, XrefRangeEnd = 590777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateDictAttribute(AttributeDefinition<Dictionary<T, U>> attribute, T key, Func<U> defaultValue, Func<U, U> valueUpdate, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = key;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueUpdate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Dictionary_2_T_U_T_Func_1_U_Func_2_U_U_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0006F080 File Offset: 0x0006D280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590777, XrefRangeEnd = 590831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UpdateDictAttribute<T, U> SetAtKey(AttributeDefinition<Dictionary<T, U>> attribute, T key, U value, Match m)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = key;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(U).IsValueType)
			{
				U u = value;
				intPtr2 = ((u is string) ? IL2CPP.ManagedStringToIl2Cpp(u as string) : IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>.NativeMethodInfoPtr_SetAtKey_Public_Static_UpdateDictAttribute_2_T_U_AttributeDefinition_1_Dictionary_2_T_U_T_U_Match_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<UpdateDictAttribute<T, U>>(intPtr5) : null;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0006F168 File Offset: 0x0006D368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590831, XrefRangeEnd = 590834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDictAttribute<T, U>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0000A3F2 File Offset: 0x000085F2
		public UpdateDictAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0006F1B4 File Offset: 0x0006D3B4
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x0000A3FB File Offset: 0x000085FB
		public unsafe AttributeDefinition<Dictionary<T, U>> attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<T, U>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x0006F1E4 File Offset: 0x0006D3E4
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x0006F20C File Offset: 0x0006D40C
		public unsafe T key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.NativeFieldInfoPtr_key);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.NativeFieldInfoPtr_key);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x0006F2B4 File Offset: 0x0006D4B4
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x0000A41A File Offset: 0x0000861A
		public unsafe Func<U> defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.NativeFieldInfoPtr_defaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<U>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.NativeFieldInfoPtr_defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0006F2E4 File Offset: 0x0006D4E4
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x0000A439 File Offset: 0x00008639
		public unsafe Func<U, U> valueUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.NativeFieldInfoPtr_valueUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<U, U>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.NativeFieldInfoPtr_valueUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeFieldInfoPtr_valueUpdate;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_Dictionary_2_T_U_T_Func_1_U_Func_2_U_U_Match_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_SetAtKey_Public_Static_UpdateDictAttribute_2_T_U_AttributeDefinition_1_Dictionary_2_T_U_T_U_Match_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000439 RID: 1081
		[ObfuscatedName("Canis.actions.UpdateDictAttribute`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002F96 RID: 12182 RVA: 0x000C67A8 File Offset: 0x000C49A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c>.NativeClassPtr);
				UpdateDictAttribute<T, U>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c>.NativeClassPtr, "<>9");
				UpdateDictAttribute<T, U>.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c>.NativeClassPtr, "<>9__5_0");
				UpdateDictAttribute<T, U>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c>.NativeClassPtr, 100668050);
				UpdateDictAttribute<T, U>.__c.NativeMethodInfoPtr__SetAtKey_b__5_0_Internal_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c>.NativeClassPtr, 100668051);
			}

			// Token: 0x06002F97 RID: 12183 RVA: 0x000C6870 File Offset: 0x000C4A70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F98 RID: 12184 RVA: 0x000C68AC File Offset: 0x000C4AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590707, XrefRangeEnd = 590713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe U _SetAtKey_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>.__c.NativeMethodInfoPtr__SetAtKey_b__5_0_Internal_U_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<U>(intPtr, false, true);
			}

			// Token: 0x06002F99 RID: 12185 RVA: 0x00016BFE File Offset: 0x00014DFE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C6C RID: 3180
			// (get) Token: 0x06002F9A RID: 12186 RVA: 0x000C68E8 File Offset: 0x000C4AE8
			// (set) Token: 0x06002F9B RID: 12187 RVA: 0x00016C07 File Offset: 0x00014E07
			public unsafe static UpdateDictAttribute<T, U>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UpdateDictAttribute<T, U>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateDictAttribute<T, U>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UpdateDictAttribute<T, U>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C6D RID: 3181
			// (get) Token: 0x06002F9C RID: 12188 RVA: 0x000C6910 File Offset: 0x000C4B10
			// (set) Token: 0x06002F9D RID: 12189 RVA: 0x00016C19 File Offset: 0x00014E19
			public unsafe static Func<U> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UpdateDictAttribute<T, U>.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<U>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UpdateDictAttribute<T, U>.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DC8 RID: 7624
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001DC9 RID: 7625
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001DCA RID: 7626
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001DCB RID: 7627
			private static readonly IntPtr NativeMethodInfoPtr__SetAtKey_b__5_0_Internal_U_0;
		}

		// Token: 0x0200043A RID: 1082
		[ObfuscatedName("Canis.actions.UpdateDictAttribute`2+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06002F9E RID: 12190 RVA: 0x000C6938 File Offset: 0x000C4B38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c__DisplayClass5_0>.NativeClassPtr);
				UpdateDictAttribute<T, U>.__c__DisplayClass5_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c__DisplayClass5_0>.NativeClassPtr, "value");
				UpdateDictAttribute<T, U>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c__DisplayClass5_0>.NativeClassPtr, 100668052);
				UpdateDictAttribute<T, U>.__c__DisplayClass5_0.NativeMethodInfoPtr__SetAtKey_b__1_Internal_U_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c__DisplayClass5_0>.NativeClassPtr, 100668053);
			}

			// Token: 0x06002F9F RID: 12191 RVA: 0x000C69EC File Offset: 0x000C4BEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDictAttribute<T, U>.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA0 RID: 12192 RVA: 0x000C6A28 File Offset: 0x000C4C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590713, XrefRangeEnd = 590717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe U _SetAtKey_b__1(U prev)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(U).IsValueType)
					{
						U u = prev;
						intPtr = ((u is string) ? IL2CPP.ManagedStringToIl2Cpp(u as string) : IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref prev;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>.__c__DisplayClass5_0.NativeMethodInfoPtr__SetAtKey_b__1_Internal_U_U_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<U>(intPtr2, false, true);
				}
			}

			// Token: 0x06002FA1 RID: 12193 RVA: 0x00016C2B File Offset: 0x00014E2B
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C6E RID: 3182
			// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x000C6AA8 File Offset: 0x000C4CA8
			// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x000C6AD0 File Offset: 0x000C4CD0
			public unsafe U value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.__c__DisplayClass5_0.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<U>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>.__c__DisplayClass5_0.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(U);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04001DCC RID: 7628
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001DCD RID: 7629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001DCE RID: 7630
			private static readonly IntPtr NativeMethodInfoPtr__SetAtKey_b__1_Internal_U_U_0;
		}

		// Token: 0x0200043B RID: 1083
		[ObfuscatedName("Canis.actions.UpdateDictAttribute`2+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06002FA4 RID: 12196 RVA: 0x000C6B78 File Offset: 0x000C4D78
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateDictAttribute<T, U>>.NativeClassPtr, "<execute>d__6"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr);
				UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, "<>1__state");
				UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, "<>2__current");
				UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, "<>l__initialThreadId");
				UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, "<>4__this");
				UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, 100668054);
				UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, 100668055);
				UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, 100668056);
				UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, 100668057);
				UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, 100668058);
				UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, 100668059);
				UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, 100668060);
				UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr, 100668061);
			}

			// Token: 0x06002FA5 RID: 12197 RVA: 0x000C6CE0 File Offset: 0x000C4EE0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDictAttribute<T, U>._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002FA6 RID: 12198 RVA: 0x000C6D28 File Offset: 0x000C4F28
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FA7 RID: 12199 RVA: 0x000C6D5C File Offset: 0x000C4F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590717, XrefRangeEnd = 590763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C73 RID: 3187
			// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x000C6D98 File Offset: 0x000C4F98
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x000C6DD8 File Offset: 0x000C4FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C74 RID: 3188
			// (get) Token: 0x06002FAA RID: 12202 RVA: 0x000C6E0C File Offset: 0x000C500C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002FAB RID: 12203 RVA: 0x000C6E4C File Offset: 0x000C504C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590763, XrefRangeEnd = 590764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002FAC RID: 12204 RVA: 0x000C6E8C File Offset: 0x000C508C
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDictAttribute<T, U>._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002FAD RID: 12205 RVA: 0x00016C34 File Offset: 0x00014E34
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C6F RID: 3183
			// (get) Token: 0x06002FAE RID: 12206 RVA: 0x000C6ECC File Offset: 0x000C50CC
			// (set) Token: 0x06002FAF RID: 12207 RVA: 0x00016C3D File Offset: 0x00014E3D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C70 RID: 3184
			// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x000C6EF4 File Offset: 0x000C50F4
			// (set) Token: 0x06002FB1 RID: 12209 RVA: 0x00016C58 File Offset: 0x00014E58
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C71 RID: 3185
			// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x000C6F24 File Offset: 0x000C5124
			// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x00016C77 File Offset: 0x00014E77
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000C72 RID: 3186
			// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x000C6F4C File Offset: 0x000C514C
			// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x00016C92 File Offset: 0x00014E92
			public unsafe UpdateDictAttribute<T, U> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateDictAttribute<T, U>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDictAttribute<T, U>._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DCF RID: 7631
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001DD0 RID: 7632
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001DD1 RID: 7633
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001DD2 RID: 7634
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DD3 RID: 7635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001DD4 RID: 7636
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DD5 RID: 7637
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001DD6 RID: 7638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001DD7 RID: 7639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001DD8 RID: 7640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001DD9 RID: 7641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001DDA RID: 7642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
