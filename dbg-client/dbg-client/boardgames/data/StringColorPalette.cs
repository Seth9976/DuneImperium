using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.data
{
	// Token: 0x02000195 RID: 405
	public class StringColorPalette : ScriptableObject
	{
		// Token: 0x06001209 RID: 4617 RVA: 0x00057048 File Offset: 0x00055248
		// Note: this type is marked as 'beforefieldinit'.
		static StringColorPalette()
		{
			Il2CppClassPointerStore<StringColorPalette>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "StringColorPalette");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringColorPalette>.NativeClassPtr);
			StringColorPalette.NativeFieldInfoPtr_colorPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringColorPalette>.NativeClassPtr, "colorPairs");
			StringColorPalette.NativeMethodInfoPtr_get_ColorPairs_Public_get_Il2CppReferenceArray_1_StringColorUnityColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringColorPalette>.NativeClassPtr, 100665822);
			StringColorPalette.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringColorPalette>.NativeClassPtr, 100665823);
			StringColorPalette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringColorPalette>.NativeClassPtr, 100665824);
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x000570C8 File Offset: 0x000552C8
		public unsafe Il2CppReferenceArray<StringColorPalette.StringColorUnityColorPair> ColorPairs
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringColorPalette.NativeMethodInfoPtr_get_ColorPairs_Public_get_Il2CppReferenceArray_1_StringColorUnityColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringColorPalette.StringColorUnityColorPair>>(intPtr3) : null;
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00057108 File Offset: 0x00055308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515724, XrefRangeEnd = 515726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(string key, out Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringColorPalette.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00057164 File Offset: 0x00055364
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringColorPalette()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringColorPalette>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringColorPalette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0000A9EC File Offset: 0x00008BEC
		public StringColorPalette(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000571A0 File Offset: 0x000553A0
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0000A9F5 File Offset: 0x00008BF5
		public unsafe Il2CppReferenceArray<StringColorPalette.StringColorUnityColorPair> colorPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringColorPalette.NativeFieldInfoPtr_colorPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringColorPalette.StringColorUnityColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringColorPalette.NativeFieldInfoPtr_colorPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeFieldInfoPtr_colorPairs;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorPairs_Public_get_Il2CppReferenceArray_1_StringColorUnityColorPair_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_Color_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200037D RID: 893
		[Serializable]
		public class StringColorUnityColorPair : global::Il2CppSystem.Object
		{
			// Token: 0x060029D8 RID: 10712 RVA: 0x000A5AE4 File Offset: 0x000A3CE4
			// Note: this type is marked as 'beforefieldinit'.
			static StringColorUnityColorPair()
			{
				Il2CppClassPointerStore<StringColorPalette.StringColorUnityColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StringColorPalette>.NativeClassPtr, "StringColorUnityColorPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringColorPalette.StringColorUnityColorPair>.NativeClassPtr);
				StringColorPalette.StringColorUnityColorPair.NativeFieldInfoPtr_StringColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringColorPalette.StringColorUnityColorPair>.NativeClassPtr, "StringColor");
				StringColorPalette.StringColorUnityColorPair.NativeFieldInfoPtr_UnityColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringColorPalette.StringColorUnityColorPair>.NativeClassPtr, "UnityColor");
				StringColorPalette.StringColorUnityColorPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringColorPalette.StringColorUnityColorPair>.NativeClassPtr, 100665825);
			}

			// Token: 0x060029D9 RID: 10713 RVA: 0x000A5B4C File Offset: 0x000A3D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515720, XrefRangeEnd = 515724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringColorUnityColorPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringColorPalette.StringColorUnityColorPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringColorPalette.StringColorUnityColorPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029DA RID: 10714 RVA: 0x0001592D File Offset: 0x00013B2D
			public StringColorUnityColorPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC1 RID: 3009
			// (get) Token: 0x060029DB RID: 10715 RVA: 0x000A5B88 File Offset: 0x000A3D88
			// (set) Token: 0x060029DC RID: 10716 RVA: 0x00015936 File Offset: 0x00013B36
			public unsafe string StringColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringColorPalette.StringColorUnityColorPair.NativeFieldInfoPtr_StringColor);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringColorPalette.StringColorUnityColorPair.NativeFieldInfoPtr_StringColor), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000BC2 RID: 3010
			// (get) Token: 0x060029DD RID: 10717 RVA: 0x000A5BB0 File Offset: 0x000A3DB0
			// (set) Token: 0x060029DE RID: 10718 RVA: 0x00015955 File Offset: 0x00013B55
			public unsafe Color UnityColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringColorPalette.StringColorUnityColorPair.NativeFieldInfoPtr_UnityColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringColorPalette.StringColorUnityColorPair.NativeFieldInfoPtr_UnityColor)) = value;
				}
			}

			// Token: 0x04001A20 RID: 6688
			private static readonly IntPtr NativeFieldInfoPtr_StringColor;

			// Token: 0x04001A21 RID: 6689
			private static readonly IntPtr NativeFieldInfoPtr_UnityColor;

			// Token: 0x04001A22 RID: 6690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
