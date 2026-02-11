using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000012 RID: 18
	public static class TMPro_ExtensionMethods : global::Il2CppSystem.Object
	{
		// Token: 0x06000211 RID: 529 RVA: 0x000113CC File Offset: 0x0000F5CC
		// Note: this type is marked as 'beforefieldinit'.
		static TMPro_ExtensionMethods()
		{
			Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMPro_ExtensionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663553);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663554);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663555);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663556);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663557);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663558);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663559);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663560);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663561);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663562);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663563);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663564);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663565);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663566);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663567);
			TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr, 100663568);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001153C File Offset: 0x0000F73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037851, XrefRangeEnd = 1037856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> ToIntArray(this string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00011580 File Offset: 0x0000F780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037856, XrefRangeEnd = 1037864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ArrayToString(this Il2CppStructArray<char> chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000115BC File Offset: 0x0000F7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037864, XrefRangeEnd = 1037871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(this Il2CppStructArray<int> unicodes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000115F8 File Offset: 0x0000F7F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1037882, RefRangeEnd = 1037883, XrefRangeStart = 1037871, XrefRangeEnd = 1037882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UintToString(this List<uint> unicodes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00011634 File Offset: 0x0000F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037883, XrefRangeEnd = 1037889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(this Il2CppStructArray<int> unicodes, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unicodes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001168C File Offset: 0x0000F88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037889, XrefRangeEnd = 1037894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindInstanceID<T>(this List<T> list, T target) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = target;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref target;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.MethodInfoStoreGeneric_FindInstanceID_Public_Static_Int32_List_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00011718 File Offset: 0x0000F918
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1037894, RefRangeEnd = 1037900, XrefRangeStart = 1037894, XrefRangeEnd = 1037894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Compare(this Color32 a, Color32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00011764 File Offset: 0x0000F964
		[CallerCount(0)]
		public unsafe static bool CompareRGB(this Color32 a, Color32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000117B0 File Offset: 0x0000F9B0
		[CallerCount(0)]
		public unsafe static bool Compare(this Color a, Color b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000117FC File Offset: 0x0000F9FC
		[CallerCount(0)]
		public unsafe static bool CompareRGB(this Color a, Color b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00011848 File Offset: 0x0000FA48
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1037900, RefRangeEnd = 1037912, XrefRangeStart = 1037900, XrefRangeEnd = 1037900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Multiply(this Color32 c1, Color32 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00011894 File Offset: 0x0000FA94
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1037900, RefRangeEnd = 1037912, XrefRangeStart = 1037900, XrefRangeEnd = 1037912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Tint(this Color32 c1, Color32 c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037912, XrefRangeEnd = 1037916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Tint(this Color32 c1, float tint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001192C File Offset: 0x0000FB2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1037916, RefRangeEnd = 1037920, XrefRangeStart = 1037916, XrefRangeEnd = 1037916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color MinAlpha(this Color c1, Color c2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00011978 File Offset: 0x0000FB78
		[CallerCount(0)]
		public unsafe static bool Compare(this Vector3 v1, Vector3 v2, int accuracy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accuracy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000119D4 File Offset: 0x0000FBD4
		[CallerCount(0)]
		public unsafe static bool Compare(this Quaternion q1, Quaternion q2, int accuracy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref q1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accuracy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_ExtensionMethods.NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002CBE File Offset: 0x00000EBE
		public TMPro_ExtensionMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_Il2CppStructArray_1_Int32_String_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_UintToString_Internal_Static_String_List_1_UInt32_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color32_Color32_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color32_Color32_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Color_Color_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_CompareRGB_Public_Static_Boolean_Color_Color_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Color32_Color32_Color32_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Color32_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_Tint_Public_Static_Color32_Color32_Single_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_MinAlpha_Public_Static_Color_Color_Color_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Vector3_Vector3_Int32_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Boolean_Quaternion_Quaternion_Int32_0;

		// Token: 0x0200007A RID: 122
		private sealed class MethodInfoStoreGeneric_FindInstanceID_Public_Static_Int32_List_1_T_T_0<T>
		{
			// Token: 0x04000B97 RID: 2967
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TMPro_ExtensionMethods.NativeMethodInfoPtr_FindInstanceID_Public_Static_Int32_List_1_T_T_0, Il2CppClassPointerStore<TMPro_ExtensionMethods>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
