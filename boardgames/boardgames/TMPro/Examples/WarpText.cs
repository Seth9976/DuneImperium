using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000028 RID: 40
	public class WarpText : MonoBehaviour
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00014A9C File Offset: 0x00012C9C
		// Note: this type is marked as 'beforefieldinit'.
		static WarpText()
		{
			Il2CppClassPointerStore<WarpText>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "TMPro.Examples", "WarpText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarpText>.NativeClassPtr);
			WarpText.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpText>.NativeClassPtr, "m_TextComponent");
			WarpText.NativeFieldInfoPtr_VertexCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpText>.NativeClassPtr, "VertexCurve");
			WarpText.NativeFieldInfoPtr_AngleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpText>.NativeClassPtr, "AngleMultiplier");
			WarpText.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpText>.NativeClassPtr, "SpeedMultiplier");
			WarpText.NativeFieldInfoPtr_CurveScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarpText>.NativeClassPtr, "CurveScale");
			WarpText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpText>.NativeClassPtr, 100663542);
			WarpText.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpText>.NativeClassPtr, 100663543);
			WarpText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpText>.NativeClassPtr, 100663544);
			WarpText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarpText>.NativeClassPtr, 100663545);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00014B80 File Offset: 0x00012D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983538, XrefRangeEnd = 983544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00014BB4 File Offset: 0x00012DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983544, XrefRangeEnd = 983546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpText.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00014BE8 File Offset: 0x00012DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983546, XrefRangeEnd = 983560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00014C1C File Offset: 0x00012E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983560, XrefRangeEnd = 983571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WarpText()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarpText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarpText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000029C4 File Offset: 0x00000BC4
		public WarpText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00014C58 File Offset: 0x00012E58
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000029CD File Offset: 0x00000BCD
		public unsafe TMP_Text m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00014C88 File Offset: 0x00012E88
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000029EC File Offset: 0x00000BEC
		public unsafe AnimationCurve VertexCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_VertexCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_VertexCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00014CB8 File Offset: 0x00012EB8
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002A0B File Offset: 0x00000C0B
		public unsafe float AngleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_AngleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_AngleMultiplier)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00014CE0 File Offset: 0x00012EE0
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002A26 File Offset: 0x00000C26
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00014D08 File Offset: 0x00012F08
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002A41 File Offset: 0x00000C41
		public unsafe float CurveScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_CurveScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarpText.NativeFieldInfoPtr_CurveScale)) = value;
			}
		}

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_VertexCurve;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_AngleMultiplier;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_CurveScale;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
