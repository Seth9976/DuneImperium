using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E8 RID: 488
	public sealed class UQueryState<T> : ValueType where T : VisualElement
	{
		// Token: 0x06002693 RID: 9875 RVA: 0x000AB6EC File Offset: 0x000A98EC
		// Note: this type is marked as 'beforefieldinit'.
		static UQueryState()
		{
			Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UQueryState`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr);
			UQueryState<T>.NativeFieldInfoPtr_s_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, "s_Action");
			UQueryState<T>.NativeFieldInfoPtr_m_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, "m_Element");
			UQueryState<T>.NativeFieldInfoPtr_m_Matchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, "m_Matchers");
			UQueryState<T>.NativeFieldInfoPtr_s_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, "s_List");
			UQueryState<T>.NativeFieldInfoPtr_s_EnumerationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, "s_EnumerationList");
			UQueryState<T>.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_List_1_RuleMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669162);
			UQueryState<T>.NativeMethodInfoPtr_RebuildOn_Public_UQueryState_1_T_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669163);
			UQueryState<T>.NativeMethodInfoPtr_Single_Private_T_SingleQueryMatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669164);
			UQueryState<T>.NativeMethodInfoPtr_First_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669165);
			UQueryState<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669166);
			UQueryState<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669167);
			UQueryState<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669168);
			UQueryState<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UQueryState_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669169);
			UQueryState<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669170);
			UQueryState<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, 100669171);
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000AB884 File Offset: 0x000A9A84
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342355, XrefRangeEnd = 342357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UQueryState(VisualElement element, List<RuleMatcher> matchers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_List_1_RuleMatcher_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000AB8E8 File Offset: 0x000A9AE8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 342598, RefRangeEnd = 342606, XrefRangeStart = 342595, XrefRangeEnd = 342598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UQueryState<T> RebuildOn(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_RebuildOn_Public_UQueryState_1_T_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new UQueryState<T>(intPtr);
			}
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000AB938 File Offset: 0x000A9B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342606, XrefRangeEnd = 342615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Single(UQuery.SingleQueryMatcher matcher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_Single_Private_T_SingleQueryMatcher_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x000AB988 File Offset: 0x000A9B88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 342624, RefRangeEnd = 342629, XrefRangeStart = 342615, XrefRangeEnd = 342624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T First()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_First_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x000AB9C8 File Offset: 0x000A9BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342629, XrefRangeEnd = 342631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UQueryState<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new UQueryState<T>.Enumerator(intPtr);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000ABA04 File Offset: 0x000A9C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342631, XrefRangeEnd = 342639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000ABA48 File Offset: 0x000A9C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000ABA8C File Offset: 0x000A9C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342639, XrefRangeEnd = 342640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(UQueryState<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UQueryState_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000ABAE4 File Offset: 0x000A9CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342640, XrefRangeEnd = 342653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000ABB38 File Offset: 0x000A9D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342653, XrefRangeEnd = 342659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0000FA5E File Offset: 0x0000DC5E
		public UQueryState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x0000FA67 File Offset: 0x0000DC67
		public UQueryState()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x000ABB7C File Offset: 0x000A9D7C
		// (set) Token: 0x060026A1 RID: 9889 RVA: 0x0000FA79 File Offset: 0x0000DC79
		public unsafe static UQueryState<T>.ActionQueryMatcher s_Action
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UQueryState<T>.NativeFieldInfoPtr_s_Action, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UQueryState<T>.ActionQueryMatcher>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryState<T>.NativeFieldInfoPtr_s_Action, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x000ABBA4 File Offset: 0x000A9DA4
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x0000FA8B File Offset: 0x0000DC8B
		public unsafe VisualElement m_Element
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.NativeFieldInfoPtr_m_Element);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.NativeFieldInfoPtr_m_Element), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x000ABBD4 File Offset: 0x000A9DD4
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x0000FAAA File Offset: 0x0000DCAA
		public unsafe List<RuleMatcher> m_Matchers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.NativeFieldInfoPtr_m_Matchers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RuleMatcher>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.NativeFieldInfoPtr_m_Matchers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000ABC04 File Offset: 0x000A9E04
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x0000FAC9 File Offset: 0x0000DCC9
		public unsafe static UQueryState<T>.ListQueryMatcher<T> s_List
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UQueryState<T>.NativeFieldInfoPtr_s_List, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UQueryState<T>.ListQueryMatcher<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryState<T>.NativeFieldInfoPtr_s_List, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x000ABC2C File Offset: 0x000A9E2C
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x0000FADB File Offset: 0x0000DCDB
		public unsafe static UQueryState<T>.ListQueryMatcher<VisualElement> s_EnumerationList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UQueryState<T>.NativeFieldInfoPtr_s_EnumerationList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UQueryState<T>.ListQueryMatcher<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryState<T>.NativeFieldInfoPtr_s_EnumerationList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x0000FAED File Offset: 0x0000DCED
		public T Last()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x0000FAFA File Offset: 0x0000DCFA
		public void ToList(List<T> results)
		{
			UQueryState.s_List.matches = results;
			UQueryState.s_List.Run(this.m_Element, this.m_Matchers);
			UQueryState.s_List.Reset();
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000ABC54 File Offset: 0x000A9E54
		public List<T> ToList()
		{
			List<T> list = new List<T>();
			this.ToList(list);
			return list;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x0000FB2B File Offset: 0x0000DD2B
		public T AtIndex(int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x000ABC78 File Offset: 0x000A9E78
		public void ForEach(Action<T> funcCall)
		{
			UQueryState<T>.ActionQueryMatcher actionQueryMatcher = UQueryState.s_Action;
			bool flag = actionQueryMatcher.callBack != null;
			if (flag)
			{
				actionQueryMatcher = new UQueryState<T>.ActionQueryMatcher();
			}
			try
			{
				actionQueryMatcher.callBack = funcCall;
				actionQueryMatcher.Run(this.m_Element, this.m_Matchers);
			}
			finally
			{
				actionQueryMatcher.callBack = null;
			}
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x0000FB38 File Offset: 0x0000DD38
		public void ForEach<T2>(List<T2> result, Func<T, T2> funcCall)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000ABCDC File Offset: 0x000A9EDC
		public List<T2> ForEach<T2>(Func<T, T2> funcCall)
		{
			List<T2> list = new List<T2>();
			this.ForEach<T2>(list, funcCall);
			return list;
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000ABD00 File Offset: 0x000A9F00
		public static bool operator ==(UQueryState<T> state1, UQueryState<T> state2)
		{
			return state1.Equals(state2);
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000ABD1C File Offset: 0x000A9F1C
		public static bool operator !=(UQueryState<T> state1, UQueryState<T> state2)
		{
			return !(state1 == state2);
		}

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeFieldInfoPtr_s_Action;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeFieldInfoPtr_m_Element;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeFieldInfoPtr_m_Matchers;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeFieldInfoPtr_s_List;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeFieldInfoPtr_s_EnumerationList;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_List_1_RuleMatcher_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_RebuildOn_Public_UQueryState_1_T_VisualElement_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_Single_Private_T_SingleQueryMatcher_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_First_Public_T_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UQueryState_1_T_0;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020004F6 RID: 1270
		public class ListQueryMatcher<TElement> : UQuery.UQueryMatcher where TElement : VisualElement
		{
			// Token: 0x06003F7F RID: 16255 RVA: 0x000FCF40 File Offset: 0x000FB140
			// Note: this type is marked as 'beforefieldinit'.
			static ListQueryMatcher()
			{
				Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, "ListQueryMatcher`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr);
				UQueryState<T>.ListQueryMatcher<TElement>.NativeFieldInfoPtr__matches_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr, "<matches>k__BackingField");
				UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr_get_matches_Public_get_List_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr, 100669173);
				UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr_set_matches_Public_set_Void_List_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr, 100669174);
				UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr, 100669175);
				UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr, 100669176);
				UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr, 100669177);
			}

			// Token: 0x17001308 RID: 4872
			// (get) Token: 0x06003F80 RID: 16256 RVA: 0x000FD030 File Offset: 0x000FB230
			// (set) Token: 0x06003F81 RID: 16257 RVA: 0x000FD070 File Offset: 0x000FB270
			public unsafe List<TElement> matches
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr_get_matches_Public_get_List_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TElement>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr_set_matches_Public_set_Void_List_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06003F82 RID: 16258 RVA: 0x000FD0B4 File Offset: 0x000FB2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342299, XrefRangeEnd = 342307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(matcher));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F83 RID: 16259 RVA: 0x000FD124 File Offset: 0x000FB324
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 342312, RefRangeEnd = 342313, XrefRangeStart = 342307, XrefRangeEnd = 342312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F84 RID: 16260 RVA: 0x000FD158 File Offset: 0x000FB358
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ListQueryMatcher()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQueryState<T>.ListQueryMatcher<TElement>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.ListQueryMatcher<TElement>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F85 RID: 16261 RVA: 0x0001AA1A File Offset: 0x00018C1A
			public ListQueryMatcher(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001307 RID: 4871
			// (get) Token: 0x06003F86 RID: 16262 RVA: 0x000FD194 File Offset: 0x000FB394
			// (set) Token: 0x06003F87 RID: 16263 RVA: 0x0001AA23 File Offset: 0x00018C23
			public unsafe List<TElement> _matches_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.ListQueryMatcher<TElement>.NativeFieldInfoPtr__matches_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.ListQueryMatcher<TElement>.NativeFieldInfoPtr__matches_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CDA RID: 11482
			private static readonly IntPtr NativeFieldInfoPtr__matches_k__BackingField;

			// Token: 0x04002CDB RID: 11483
			private static readonly IntPtr NativeMethodInfoPtr_get_matches_Public_get_List_1_TElement_0;

			// Token: 0x04002CDC RID: 11484
			private static readonly IntPtr NativeMethodInfoPtr_set_matches_Public_set_Void_List_1_TElement_0;

			// Token: 0x04002CDD RID: 11485
			private static readonly IntPtr NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0;

			// Token: 0x04002CDE RID: 11486
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

			// Token: 0x04002CDF RID: 11487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004F7 RID: 1271
		public class ActionQueryMatcher : UQuery.UQueryMatcher
		{
			// Token: 0x06003F88 RID: 16264 RVA: 0x000FD1C4 File Offset: 0x000FB3C4
			// Note: this type is marked as 'beforefieldinit'.
			static ActionQueryMatcher()
			{
				Il2CppClassPointerStore<UQueryState<T>.ActionQueryMatcher>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, "ActionQueryMatcher"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQueryState<T>.ActionQueryMatcher>.NativeClassPtr);
				UQueryState<T>.ActionQueryMatcher.NativeFieldInfoPtr__callBack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>.ActionQueryMatcher>.NativeClassPtr, "<callBack>k__BackingField");
				UQueryState<T>.ActionQueryMatcher.NativeMethodInfoPtr_get_callBack_Internal_get_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.ActionQueryMatcher>.NativeClassPtr, 100669178);
				UQueryState<T>.ActionQueryMatcher.NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.ActionQueryMatcher>.NativeClassPtr, 100669179);
				UQueryState<T>.ActionQueryMatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.ActionQueryMatcher>.NativeClassPtr, 100669180);
			}

			// Token: 0x1700130A RID: 4874
			// (get) Token: 0x06003F89 RID: 16265 RVA: 0x000FD27C File Offset: 0x000FB47C
			public unsafe Action<T> callBack
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.ActionQueryMatcher.NativeMethodInfoPtr_get_callBack_Internal_get_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr3) : null;
				}
			}

			// Token: 0x06003F8A RID: 16266 RVA: 0x000FD2BC File Offset: 0x000FB4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342313, XrefRangeEnd = 342317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(matcher));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UQueryState<T>.ActionQueryMatcher.NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F8B RID: 16267 RVA: 0x000FD32C File Offset: 0x000FB52C
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ActionQueryMatcher()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQueryState<T>.ActionQueryMatcher>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.ActionQueryMatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F8C RID: 16268 RVA: 0x0001AA42 File Offset: 0x00018C42
			public ActionQueryMatcher(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001309 RID: 4873
			// (get) Token: 0x06003F8D RID: 16269 RVA: 0x000FD368 File Offset: 0x000FB568
			// (set) Token: 0x06003F8E RID: 16270 RVA: 0x0001AA4B File Offset: 0x00018C4B
			public unsafe Action<T> _callBack_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.ActionQueryMatcher.NativeFieldInfoPtr__callBack_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.ActionQueryMatcher.NativeFieldInfoPtr__callBack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CE0 RID: 11488
			private static readonly IntPtr NativeFieldInfoPtr__callBack_k__BackingField;

			// Token: 0x04002CE1 RID: 11489
			private static readonly IntPtr NativeMethodInfoPtr_get_callBack_Internal_get_Action_1_T_0;

			// Token: 0x04002CE2 RID: 11490
			private static readonly IntPtr NativeMethodInfoPtr_OnRuleMatchedElement_Protected_Virtual_Boolean_RuleMatcher_VisualElement_0;

			// Token: 0x04002CE3 RID: 11491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020004F8 RID: 1272
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06003F8F RID: 16271 RVA: 0x000FD398 File Offset: 0x000FB598
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UQueryState<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr);
				UQueryState<T>.Enumerator.NativeFieldInfoPtr_iterationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr, "iterationList");
				UQueryState<T>.Enumerator.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr, "currentIndex");
				UQueryState<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_UQueryState_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr, 100669181);
				UQueryState<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr, 100669182);
				UQueryState<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr, 100669183);
				UQueryState<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr, 100669184);
				UQueryState<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr, 100669185);
				UQueryState<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr, 100669186);
			}

			// Token: 0x06003F90 RID: 16272 RVA: 0x000FD4A0 File Offset: 0x000FB6A0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 342335, RefRangeEnd = 342338, XrefRangeStart = 342317, XrefRangeEnd = 342335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(UQueryState<T> queryState)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(queryState));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_UQueryState_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700130D RID: 4877
			// (get) Token: 0x06003F91 RID: 16273 RVA: 0x000FD4F8 File Offset: 0x000FB6F8
			public unsafe T Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342338, XrefRangeEnd = 342343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x1700130E RID: 4878
			// (get) Token: 0x06003F92 RID: 16274 RVA: 0x000FD538 File Offset: 0x000FB738
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342343, XrefRangeEnd = 342349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003F93 RID: 16275 RVA: 0x000FD57C File Offset: 0x000FB77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342349, XrefRangeEnd = 342350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F94 RID: 16276 RVA: 0x000FD5C0 File Offset: 0x000FB7C0
			[CallerCount(0)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F95 RID: 16277 RVA: 0x000FD5F8 File Offset: 0x000FB7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342350, XrefRangeEnd = 342355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryState<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F96 RID: 16278 RVA: 0x0001AA6A File Offset: 0x00018C6A
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003F97 RID: 16279 RVA: 0x0001AA73 File Offset: 0x00018C73
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UQueryState<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x1700130B RID: 4875
			// (get) Token: 0x06003F98 RID: 16280 RVA: 0x000FD630 File Offset: 0x000FB830
			// (set) Token: 0x06003F99 RID: 16281 RVA: 0x0001AA85 File Offset: 0x00018C85
			public unsafe List<VisualElement> iterationList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.Enumerator.NativeFieldInfoPtr_iterationList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.Enumerator.NativeFieldInfoPtr_iterationList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700130C RID: 4876
			// (get) Token: 0x06003F9A RID: 16282 RVA: 0x000FD660 File Offset: 0x000FB860
			// (set) Token: 0x06003F9B RID: 16283 RVA: 0x0001AAA4 File Offset: 0x00018CA4
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.Enumerator.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UQueryState<T>.Enumerator.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x04002CE4 RID: 11492
			private static readonly IntPtr NativeFieldInfoPtr_iterationList;

			// Token: 0x04002CE5 RID: 11493
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x04002CE6 RID: 11494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UQueryState_1_T_0;

			// Token: 0x04002CE7 RID: 11495
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04002CE8 RID: 11496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002CE9 RID: 11497
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002CEA RID: 11498
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002CEB RID: 11499
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}
	}
}
