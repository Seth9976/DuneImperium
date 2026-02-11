using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001BC RID: 444
	public static class Interlocked : Object
	{
		// Token: 0x06001CF0 RID: 7408 RVA: 0x000AAE14 File Offset: 0x000A9014
		// Note: this type is marked as 'beforefieldinit'.
		static Interlocked()
		{
			Il2CppClassPointerStore<Interlocked>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Interlocked");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interlocked>.NativeClassPtr);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668273);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668274);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668275);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668276);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668277);
			Interlocked.NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668278);
			Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668279);
			Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668280);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668281);
			Interlocked.NativeMethodInfoPtr_Exchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668282);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668283);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668284);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668285);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668286);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668287);
			Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668288);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668289);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668290);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668291);
			Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668292);
			Interlocked.NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668293);
			Interlocked.NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668294);
			Interlocked.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interlocked>.NativeClassPtr, 100668295);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000AB010 File Offset: 0x000A9210
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 1357090, RefRangeEnd = 1357145, XrefRangeStart = 1357089, XrefRangeEnd = 1357090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareExchange(ref int location1, int value, int comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000AB06C File Offset: 0x000A926C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1357146, RefRangeEnd = 1357152, XrefRangeStart = 1357145, XrefRangeEnd = 1357146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &succeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000AB0D4 File Offset: 0x000A92D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357152, XrefRangeEnd = 1357153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompareExchange(ref Object location1, ref Object value, ref Object comparand, ref Object result)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(comparand);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_byref_Object_0, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			location1 = ((intPtr7 == 0) ? null : new Object(intPtr7));
			IntPtr intPtr8 = intPtr2;
			value = ((intPtr8 == 0) ? null : new Object(intPtr8));
			IntPtr intPtr9 = intPtr3;
			comparand = ((intPtr9 == 0) ? null : new Object(intPtr9));
			IntPtr intPtr10 = intPtr4;
			result = ((intPtr10 == 0) ? null : new Object(intPtr10));
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000AB19C File Offset: 0x000A939C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1357154, RefRangeEnd = 1357181, XrefRangeStart = 1357153, XrefRangeEnd = 1357154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CompareExchange(ref Object location1, Object value, Object comparand)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparand);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location1 = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000AB21C File Offset: 0x000A941C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357182, RefRangeEnd = 1357183, XrefRangeStart = 1357181, XrefRangeEnd = 1357182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CompareExchange(ref float location1, float value, float comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000AB278 File Offset: 0x000A9478
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1357184, RefRangeEnd = 1357191, XrefRangeStart = 1357183, XrefRangeEnd = 1357184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Decrement(ref int location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000AB2B8 File Offset: 0x000A94B8
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1357192, RefRangeEnd = 1357228, XrefRangeStart = 1357191, XrefRangeEnd = 1357192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Increment(ref int location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000AB2F8 File Offset: 0x000A94F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1357229, RefRangeEnd = 1357235, XrefRangeStart = 1357228, XrefRangeEnd = 1357229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Increment(ref long location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000AB338 File Offset: 0x000A9538
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1357236, RefRangeEnd = 1357260, XrefRangeStart = 1357235, XrefRangeEnd = 1357236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Exchange(ref int location1, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000AB384 File Offset: 0x000A9584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357260, XrefRangeEnd = 1357261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exchange(ref Object location1, ref Object value, ref Object result)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(result);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			location1 = ((intPtr6 == 0) ? null : new Object(intPtr6));
			IntPtr intPtr7 = intPtr2;
			value = ((intPtr7 == 0) ? null : new Object(intPtr7));
			IntPtr intPtr8 = intPtr3;
			result = ((intPtr8 == 0) ? null : new Object(intPtr8));
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000AB424 File Offset: 0x000A9624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357261, XrefRangeEnd = 1357262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Exchange(ref Object location1, Object value)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			location1 = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000AB494 File Offset: 0x000A9694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357262, XrefRangeEnd = 1357263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Exchange(ref float location1, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000AB4E0 File Offset: 0x000A96E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357264, RefRangeEnd = 1357265, XrefRangeStart = 1357263, XrefRangeEnd = 1357264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CompareExchange(ref long location1, long value, long comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000AB53C File Offset: 0x000A973C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357264, RefRangeEnd = 1357265, XrefRangeStart = 1357264, XrefRangeEnd = 1357265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x000AB598 File Offset: 0x000A9798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357265, XrefRangeEnd = 1357266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CompareExchange(ref double location1, double value, double comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x000AB5F4 File Offset: 0x000A97F4
		[CallerCount(0)]
		public unsafe static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T).IsValueType)
			{
				T t2 = comparand;
				intPtr3 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref comparand;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Interlocked.MethodInfoStoreGeneric_CompareExchange_Public_Static_T_byref_T_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			location1 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr4, false, true);
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000AB6DC File Offset: 0x000A98DC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1357267, RefRangeEnd = 1357282, XrefRangeStart = 1357266, XrefRangeEnd = 1357267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Exchange(ref long location1, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x000AB728 File Offset: 0x000A9928
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1357267, RefRangeEnd = 1357282, XrefRangeStart = 1357267, XrefRangeEnd = 1357282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Exchange(ref IntPtr location1, IntPtr value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x000AB774 File Offset: 0x000A9974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357282, XrefRangeEnd = 1357283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Exchange(ref double location1, double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000AB7C0 File Offset: 0x000A99C0
		[CallerCount(0)]
		public unsafe static T Exchange<T>(ref T location1, T value) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(location1);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Interlocked.MethodInfoStoreGeneric_Exchange_Public_Static_T_byref_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			location1 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000AB860 File Offset: 0x000A9A60
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1357284, RefRangeEnd = 1357300, XrefRangeStart = 1357283, XrefRangeEnd = 1357284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Read(ref long location)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000AB8A0 File Offset: 0x000A9AA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1357301, RefRangeEnd = 1357304, XrefRangeStart = 1357300, XrefRangeEnd = 1357301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Add(ref int location1, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &location1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000AB8EC File Offset: 0x000A9AEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1356062, RefRangeEnd = 1356068, XrefRangeStart = 1356062, XrefRangeEnd = 1356068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemoryBarrier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interlocked.NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x000094A4 File Offset: 0x000076A4
		public Interlocked(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Int32_byref_Int32_Int32_Int32_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Internal_Static_Int32_byref_Int32_Int32_Int32_byref_Boolean_0;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_byref_Object_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Object_byref_Object_Object_Object_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Single_byref_Single_Single_Single_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr_Decrement_Public_Static_Int32_byref_Int32_0;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeMethodInfoPtr_Increment_Public_Static_Int32_byref_Int32_0;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeMethodInfoPtr_Increment_Public_Static_Int64_byref_Int64_0;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Int32_byref_Int32_Int32_0;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Private_Static_Void_byref_Object_byref_Object_byref_Object_0;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Object_byref_Object_Object_0;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Single_byref_Single_Single_0;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Int64_byref_Int64_Int64_Int64_0;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_Double_byref_Double_Double_Double_0;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Int64_byref_Int64_Int64_0;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_IntPtr_byref_IntPtr_IntPtr_0;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_Double_byref_Double_Double_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Int64_byref_Int64_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Int32_byref_Int32_Int32_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_MemoryBarrier_Public_Static_Void_0;

		// Token: 0x02000617 RID: 1559
		private sealed class MethodInfoStoreGeneric_CompareExchange_Public_Static_T_byref_T_T_T_0<T>
		{
			// Token: 0x040048E5 RID: 18661
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interlocked.NativeMethodInfoPtr_CompareExchange_Public_Static_T_byref_T_T_T_0, Il2CppClassPointerStore<Interlocked>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000618 RID: 1560
		private sealed class MethodInfoStoreGeneric_Exchange_Public_Static_T_byref_T_T_0<T>
		{
			// Token: 0x040048E6 RID: 18662
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interlocked.NativeMethodInfoPtr_Exchange_Public_Static_T_byref_T_T_0, Il2CppClassPointerStore<Interlocked>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
