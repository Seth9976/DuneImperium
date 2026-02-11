using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000110 RID: 272
	public class RuleCache<T> : Object where T : class
	{
		// Token: 0x0600104C RID: 4172 RVA: 0x00055BF4 File Offset: 0x00053DF4
		// Note: this type is marked as 'beforefieldinit'.
		static RuleCache()
		{
			Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Runtime.CompilerServices", "RuleCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr);
			RuleCache<T>.NativeFieldInfoPtr__rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr, "_rules");
			RuleCache<T>.NativeFieldInfoPtr__cacheLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr, "_cacheLock");
			RuleCache<T>.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr, 100666341);
			RuleCache<T>.NativeMethodInfoPtr_GetRules_Internal_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr, 100666342);
			RuleCache<T>.NativeMethodInfoPtr_MoveRule_Internal_Void_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr, 100666343);
			RuleCache<T>.NativeMethodInfoPtr_AddRule_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr, 100666344);
			RuleCache<T>.NativeMethodInfoPtr_AddOrInsert_Private_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr, 100666345);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00055CEC File Offset: 0x00053EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1027868, RefRangeEnd = 1027869, XrefRangeStart = 1027856, XrefRangeEnd = 1027868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuleCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuleCache<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuleCache<T>.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00055D28 File Offset: 0x00053F28
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetRules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuleCache<T>.NativeMethodInfoPtr_GetRules_Internal_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00055D60 File Offset: 0x00053F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1027883, RefRangeEnd = 1027884, XrefRangeStart = 1027869, XrefRangeEnd = 1027883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRule(T rule, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = rule;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref rule;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuleCache<T>.NativeMethodInfoPtr_MoveRule_Internal_Void_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00055DE8 File Offset: 0x00053FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1027899, RefRangeEnd = 1027901, XrefRangeStart = 1027884, XrefRangeEnd = 1027899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRule(T newRule)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = newRule;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newRule;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuleCache<T>.NativeMethodInfoPtr_AddRule_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00055E60 File Offset: 0x00054060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027901, XrefRangeEnd = 1027908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> AddOrInsert(Il2CppArrayBase<T> rules, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rules);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuleCache<T>.NativeMethodInfoPtr_AddOrInsert_Private_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x000070A2 File Offset: 0x000052A2
		public RuleCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x00055EE4 File Offset: 0x000540E4
		// (set) Token: 0x06001054 RID: 4180 RVA: 0x000070AB File Offset: 0x000052AB
		public unsafe Il2CppArrayBase<T> _rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuleCache<T>.NativeFieldInfoPtr__rules);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuleCache<T>.NativeFieldInfoPtr__rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00055F0C File Offset: 0x0005410C
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x000070CA File Offset: 0x000052CA
		public unsafe Object _cacheLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuleCache<T>.NativeFieldInfoPtr__cacheLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuleCache<T>.NativeFieldInfoPtr__cacheLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr__rules;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr__cacheLock;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_GetRules_Internal_Il2CppArrayBase_1_T_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_MoveRule_Internal_Void_T_Int32_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_AddRule_Internal_Void_T_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_AddOrInsert_Private_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0;
	}
}
