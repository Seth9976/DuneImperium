using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EA RID: 490
	public static class UQueryExtensions : Object
	{
		// Token: 0x060026FD RID: 9981 RVA: 0x000AC9F8 File Offset: 0x000AABF8
		// Note: this type is marked as 'beforefieldinit'.
		static UQueryExtensions()
		{
			Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UQueryExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr);
			UQueryExtensions.NativeFieldInfoPtr_SingleElementEmptyQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, "SingleElementEmptyQuery");
			UQueryExtensions.NativeFieldInfoPtr_SingleElementNameQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, "SingleElementNameQuery");
			UQueryExtensions.NativeFieldInfoPtr_SingleElementClassQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, "SingleElementClassQuery");
			UQueryExtensions.NativeFieldInfoPtr_SingleElementNameAndClassQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, "SingleElementNameAndClassQuery");
			UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, "SingleElementTypeQuery");
			UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndNameQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, "SingleElementTypeAndNameQuery");
			UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndClassQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, "SingleElementTypeAndClassQuery");
			UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndNameAndClassQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, "SingleElementTypeAndNameAndClassQuery");
			UQueryExtensions.NativeMethodInfoPtr_Q_Public_Static_T_VisualElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, 100669203);
			UQueryExtensions.NativeMethodInfoPtr_Q_Public_Static_VisualElement_VisualElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr, 100669204);
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000ACAF0 File Offset: 0x000AACF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 342981, RefRangeEnd = 342986, XrefRangeStart = 342849, XrefRangeEnd = 342981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Q<T>(this VisualElement e, string name = null, string className = null) where T : VisualElement
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(className);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryExtensions.MethodInfoStoreGeneric_Q_Public_Static_T_VisualElement_String_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x000ACB54 File Offset: 0x000AAD54
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 343044, RefRangeEnd = 343055, XrefRangeStart = 342986, XrefRangeEnd = 343044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement Q(this VisualElement e, string name = null, string className = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(className);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UQueryExtensions.NativeMethodInfoPtr_Q_Public_Static_VisualElement_VisualElement_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x0000FC9C File Offset: 0x0000DE9C
		public UQueryExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000ACBBC File Offset: 0x000AADBC
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x0000FCA5 File Offset: 0x0000DEA5
		public unsafe static UQueryState<VisualElement> SingleElementEmptyQuery
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementEmptyQuery, intPtr);
				return new UQueryState<VisualElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementEmptyQuery, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000ACBF8 File Offset: 0x000AADF8
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x0000FCBC File Offset: 0x0000DEBC
		public unsafe static UQueryState<VisualElement> SingleElementNameQuery
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementNameQuery, intPtr);
				return new UQueryState<VisualElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementNameQuery, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x000ACC34 File Offset: 0x000AAE34
		// (set) Token: 0x06002706 RID: 9990 RVA: 0x0000FCD3 File Offset: 0x0000DED3
		public unsafe static UQueryState<VisualElement> SingleElementClassQuery
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementClassQuery, intPtr);
				return new UQueryState<VisualElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementClassQuery, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000ACC70 File Offset: 0x000AAE70
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x0000FCEA File Offset: 0x0000DEEA
		public unsafe static UQueryState<VisualElement> SingleElementNameAndClassQuery
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementNameAndClassQuery, intPtr);
				return new UQueryState<VisualElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementNameAndClassQuery, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x000ACCAC File Offset: 0x000AAEAC
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x0000FD01 File Offset: 0x0000DF01
		public unsafe static UQueryState<VisualElement> SingleElementTypeQuery
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeQuery, intPtr);
				return new UQueryState<VisualElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeQuery, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x000ACCE8 File Offset: 0x000AAEE8
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x0000FD18 File Offset: 0x0000DF18
		public unsafe static UQueryState<VisualElement> SingleElementTypeAndNameQuery
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndNameQuery, intPtr);
				return new UQueryState<VisualElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndNameQuery, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000ACD24 File Offset: 0x000AAF24
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x0000FD2F File Offset: 0x0000DF2F
		public unsafe static UQueryState<VisualElement> SingleElementTypeAndClassQuery
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndClassQuery, intPtr);
				return new UQueryState<VisualElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndClassQuery, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x000ACD60 File Offset: 0x000AAF60
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x0000FD46 File Offset: 0x0000DF46
		public unsafe static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndNameAndClassQuery, intPtr);
				return new UQueryState<VisualElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UQueryState<VisualElement>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UQueryExtensions.NativeFieldInfoPtr_SingleElementTypeAndNameAndClassQuery, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x000ACD9C File Offset: 0x000AAF9C
		public static T Q<T>(VisualElement e, [Optional] string name, Il2CppStringArray classes) where T : VisualElement
		{
			UQueryBuilder<T> uqueryBuilder = UQueryExtensions.Query<T>(e, name, classes);
			UQueryState<T> uqueryState = uqueryBuilder.Build();
			return uqueryState.First();
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x0000FD5D File Offset: 0x0000DF5D
		public static T Q<T>(VisualElement e, [Optional] string name, params string[] classes) where T : VisualElement
		{
			return UQueryExtensions.Q(e, name, new Il2CppStringArray(classes));
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x000ACDC8 File Offset: 0x000AAFC8
		public static VisualElement Q(VisualElement e, [Optional] string name, Il2CppStringArray classes)
		{
			UQueryBuilder<VisualElement> uqueryBuilder = UQueryExtensions.Query<VisualElement>(e, name, classes);
			UQueryState<VisualElement> uqueryState = uqueryBuilder.Build();
			return uqueryState.First();
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		public static VisualElement Q(VisualElement e, [Optional] string name, params string[] classes)
		{
			return UQueryExtensions.Q(e, name, new Il2CppStringArray(classes));
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000ACDF4 File Offset: 0x000AAFF4
		public static T MandatoryQ<T>(VisualElement e, string name, [Optional] string className) where T : VisualElement
		{
			T t = e.Q(name, className);
			bool flag = t == null;
			if (flag)
			{
				throw new UQueryExtensions.MissingVisualElementException(String.Concat("Element not found: ", name));
			}
			return t;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000ACE30 File Offset: 0x000AB030
		public static VisualElement MandatoryQ(VisualElement e, string name, [Optional] string className)
		{
			VisualElement visualElement = e.Q(name, className);
			bool flag = visualElement == null;
			if (flag)
			{
				throw new UQueryExtensions.MissingVisualElementException(String.Concat("Element not found: ", name));
			}
			return visualElement;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000ACE68 File Offset: 0x000AB068
		public static UQueryBuilder<VisualElement> Query(VisualElement e, [Optional] string name, Il2CppStringArray classes)
		{
			return UQueryExtensions.Query<VisualElement>(e, name, classes);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x0000FD7B File Offset: 0x0000DF7B
		public static UQueryBuilder<VisualElement> Query(VisualElement e, [Optional] string name, params string[] classes)
		{
			return UQueryExtensions.Query(e, name, new Il2CppStringArray(classes));
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000ACE84 File Offset: 0x000AB084
		public static UQueryBuilder<VisualElement> Query(VisualElement e, [Optional] string name, [Optional] string className)
		{
			return UQueryExtensions.Query<VisualElement>(e, name, className);
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000ACEA0 File Offset: 0x000AB0A0
		public static UQueryBuilder<T> Query<T>(VisualElement e, [Optional] string name, Il2CppStringArray classes) where T : VisualElement
		{
			bool flag = e == null;
			if (flag)
			{
				throw new ArgumentNullException("e");
			}
			UQueryBuilder<VisualElement> uqueryBuilder = new UQueryBuilder<VisualElement>(e);
			return uqueryBuilder.OfType<T>(name, classes);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0000FD8A File Offset: 0x0000DF8A
		public static UQueryBuilder<T> Query<T>(VisualElement e, [Optional] string name, params string[] classes) where T : VisualElement
		{
			return UQueryExtensions.Query(e, name, new Il2CppStringArray(classes));
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000ACED8 File Offset: 0x000AB0D8
		public static UQueryBuilder<T> Query<T>(VisualElement e, [Optional] string name, [Optional] string className) where T : VisualElement
		{
			bool flag = e == null;
			if (flag)
			{
				throw new ArgumentNullException("e");
			}
			UQueryBuilder<VisualElement> uqueryBuilder = new UQueryBuilder<VisualElement>(e);
			return uqueryBuilder.OfType<T>(name, className);
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000ACF10 File Offset: 0x000AB110
		public static UQueryBuilder<VisualElement> Query(VisualElement e)
		{
			bool flag = e == null;
			if (flag)
			{
				throw new ArgumentNullException("e");
			}
			return new UQueryBuilder<VisualElement>(e);
		}

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeFieldInfoPtr_SingleElementEmptyQuery;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeFieldInfoPtr_SingleElementNameQuery;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeFieldInfoPtr_SingleElementClassQuery;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeFieldInfoPtr_SingleElementNameAndClassQuery;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeFieldInfoPtr_SingleElementTypeQuery;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeFieldInfoPtr_SingleElementTypeAndNameQuery;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr_SingleElementTypeAndClassQuery;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr_SingleElementTypeAndNameAndClassQuery;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr_Q_Public_Static_T_VisualElement_String_String_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_Q_Public_Static_VisualElement_VisualElement_String_String_0;

		// Token: 0x020004F9 RID: 1273
		private sealed class MethodInfoStoreGeneric_Q_Public_Static_T_VisualElement_String_String_0<T>
		{
			// Token: 0x04002CEC RID: 11500
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UQueryExtensions.NativeMethodInfoPtr_Q_Public_Static_T_VisualElement_String_String_0, Il2CppClassPointerStore<UQueryExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004FA RID: 1274
		public class MissingVisualElementException : Exception
		{
		}
	}
}
