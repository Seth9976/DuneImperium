using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public class Variable<T> : Object
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x0001966C File Offset: 0x0001786C
		// Note: this type is marked as 'beforefieldinit'.
		static Variable()
		{
			Il2CppClassPointerStore<Variable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "Variable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr);
			Variable<T>.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, "m_Value");
			Variable<T>.NativeFieldInfoPtr_ValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, "ValueChanged");
			Variable<T>.NativeMethodInfoPtr_add_ValueChanged_Public_Virtual_Final_New_add_Void_Action_1_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100664093);
			Variable<T>.NativeMethodInfoPtr_remove_ValueChanged_Public_Virtual_Final_New_rem_Void_Action_1_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100664094);
			Variable<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100664095);
			Variable<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100664096);
			Variable<T>.NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100664097);
			Variable<T>.NativeMethodInfoPtr_SendValueChangedEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100664098);
			Variable<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100664099);
			Variable<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100664100);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000197A0 File Offset: 0x000179A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071132, XrefRangeEnd = 1071137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ValueChanged(Action<IVariable> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr_add_ValueChanged_Public_Virtual_Final_New_add_Void_Action_1_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000197E4 File Offset: 0x000179E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071137, XrefRangeEnd = 1071142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ValueChanged(Action<IVariable> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr_remove_ValueChanged_Public_Virtual_Final_New_rem_Void_Action_1_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00019828 File Offset: 0x00017A28
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00019864 File Offset: 0x00017A64
		public unsafe T Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071142, XrefRangeEnd = 1071147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000198DC File Offset: 0x00017ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071147, XrefRangeEnd = 1071148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetSourceValue(ISelectorInfo _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001992C File Offset: 0x00017B2C
		[CallerCount(0)]
		public unsafe void SendValueChangedEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr_SendValueChangedEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00019960 File Offset: 0x00017B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071148, XrefRangeEnd = 1071152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000199A4 File Offset: 0x00017BA4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Variable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000036EF File Offset: 0x000018EF
		public Variable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x000199E0 File Offset: 0x00017BE0
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00019A08 File Offset: 0x00017C08
		public unsafe T m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_m_Value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_m_Value);
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00019AB0 File Offset: 0x00017CB0
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x000036F8 File Offset: 0x000018F8
		public unsafe Action<IVariable> ValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_ValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_ValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_ValueChanged;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChanged_Public_Virtual_Final_New_add_Void_Action_1_IVariable_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChanged_Public_Virtual_Final_New_rem_Void_Action_1_IVariable_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_SendValueChangedEvent_Private_Void_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
