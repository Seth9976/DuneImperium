using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000013 RID: 19
	public static class TMP_Math : global::Il2CppSystem.Object
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00011A30 File Offset: 0x0000FC30
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Math()
		{
			Il2CppClassPointerStore<TMP_Math>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Math");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr);
			TMP_Math.NativeFieldInfoPtr_FLOAT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_MAX");
			TMP_Math.NativeFieldInfoPtr_FLOAT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_MIN");
			TMP_Math.NativeFieldInfoPtr_INT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_MAX");
			TMP_Math.NativeFieldInfoPtr_INT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_MIN");
			TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_UNSET");
			TMP_Math.NativeFieldInfoPtr_INT_UNSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_UNSET");
			TMP_Math.NativeFieldInfoPtr_MAX_16BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "MAX_16BIT");
			TMP_Math.NativeFieldInfoPtr_MIN_16BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "MIN_16BIT");
			TMP_Math.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, 100663569);
			TMP_Math.NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, 100663570);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00011B28 File Offset: 0x0000FD28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1037920, RefRangeEnd = 1037922, XrefRangeStart = 1037920, XrefRangeEnd = 1037920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Math.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00011B74 File Offset: 0x0000FD74
		[CallerCount(0)]
		public unsafe static int Mod(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Math.NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002CC7 File Offset: 0x00000EC7
		public TMP_Math(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002CD0 File Offset: 0x00000ED0
		public unsafe static float FLOAT_MAX
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MAX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MAX, (void*)(&value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00011BDC File Offset: 0x0000FDDC
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002CDE File Offset: 0x00000EDE
		public unsafe static float FLOAT_MIN
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MIN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MIN, (void*)(&value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00002CEC File Offset: 0x00000EEC
		public unsafe static int INT_MAX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_MAX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_MAX, (void*)(&value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00011C14 File Offset: 0x0000FE14
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00002CFA File Offset: 0x00000EFA
		public unsafe static int INT_MIN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_MIN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_MIN, (void*)(&value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00011C30 File Offset: 0x0000FE30
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002D08 File Offset: 0x00000F08
		public unsafe static float FLOAT_UNSET
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET, (void*)(&value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00011C4C File Offset: 0x0000FE4C
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002D16 File Offset: 0x00000F16
		public unsafe static int INT_UNSET
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_UNSET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_UNSET, (void*)(&value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00011C68 File Offset: 0x0000FE68
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002D24 File Offset: 0x00000F24
		public unsafe static Vector2 MAX_16BIT
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_MAX_16BIT, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_MAX_16BIT, (void*)(&value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00011C84 File Offset: 0x0000FE84
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002D32 File Offset: 0x00000F32
		public unsafe static Vector2 MIN_16BIT
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_MIN_16BIT, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_MIN_16BIT, (void*)(&value));
			}
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_MAX;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_MIN;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_INT_MAX;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_INT_MIN;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_UNSET;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_INT_UNSET;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_MAX_16BIT;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_MIN_16BIT;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0;
	}
}
