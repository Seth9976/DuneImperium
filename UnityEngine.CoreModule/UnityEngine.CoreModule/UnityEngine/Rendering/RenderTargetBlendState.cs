using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000245 RID: 581
	[StructLayout(2)]
	public struct RenderTargetBlendState
	{
		// Token: 0x060026EF RID: 9967 RVA: 0x000A49A4 File Offset: 0x000A2BA4
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTargetBlendState()
		{
			Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetBlendState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr);
			RenderTargetBlendState.NativeFieldInfoPtr_m_WriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_WriteMask");
			RenderTargetBlendState.NativeFieldInfoPtr_m_SourceColorBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_SourceColorBlendMode");
			RenderTargetBlendState.NativeFieldInfoPtr_m_DestinationColorBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_DestinationColorBlendMode");
			RenderTargetBlendState.NativeFieldInfoPtr_m_SourceAlphaBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_SourceAlphaBlendMode");
			RenderTargetBlendState.NativeFieldInfoPtr_m_DestinationAlphaBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_DestinationAlphaBlendMode");
			RenderTargetBlendState.NativeFieldInfoPtr_m_ColorBlendOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_ColorBlendOperation");
			RenderTargetBlendState.NativeFieldInfoPtr_m_AlphaBlendOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_AlphaBlendOperation");
			RenderTargetBlendState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_Padding");
			RenderTargetBlendState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668287);
			RenderTargetBlendState.NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668288);
			RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668289);
			RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668290);
			RenderTargetBlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100668291);
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x000A4AD8 File Offset: 0x000A2CD8
		public unsafe static RenderTargetBlendState defaultValue
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 684385, RefRangeEnd = 684393, XrefRangeStart = 684385, XrefRangeEnd = 684385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000A4B08 File Offset: 0x000A2D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684393, RefRangeEnd = 684394, XrefRangeStart = 684393, XrefRangeEnd = 684393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetBlendState(ColorWriteMask writeMask = ColorWriteMask.All, BlendMode sourceColorBlendMode = BlendMode.One, BlendMode destinationColorBlendMode = BlendMode.Zero, BlendMode sourceAlphaBlendMode = BlendMode.One, BlendMode destinationAlphaBlendMode = BlendMode.Zero, BlendOp colorBlendOperation = BlendOp.Add, BlendOp alphaBlendOperation = BlendOp.Add)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceColorBlendMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationColorBlendMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceAlphaBlendMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationAlphaBlendMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBlendOperation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlendOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000A4B90 File Offset: 0x000A2D90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 684394, RefRangeEnd = 684402, XrefRangeStart = 684394, XrefRangeEnd = 684394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderTargetBlendState other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000A4BD0 File Offset: 0x000A2DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684402, XrefRangeEnd = 684405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000A4C14 File Offset: 0x000A2E14
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 684412, RefRangeEnd = 684420, XrefRangeStart = 684405, XrefRangeEnd = 684412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0000F33E File Offset: 0x0000D53E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, ref this));
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x000A4C44 File Offset: 0x000A2E44
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x0000F350 File Offset: 0x0000D550
		public ColorWriteMask writeMask
		{
			get
			{
				return (ColorWriteMask)this.m_WriteMask;
			}
			set
			{
				this.m_WriteMask = (byte)value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x000A4C5C File Offset: 0x000A2E5C
		// (set) Token: 0x060026F9 RID: 9977 RVA: 0x0000F35B File Offset: 0x0000D55B
		public BlendMode sourceColorBlendMode
		{
			get
			{
				return (BlendMode)this.m_SourceColorBlendMode;
			}
			set
			{
				this.m_SourceColorBlendMode = (byte)value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x000A4C74 File Offset: 0x000A2E74
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x0000F366 File Offset: 0x0000D566
		public BlendMode destinationColorBlendMode
		{
			get
			{
				return (BlendMode)this.m_DestinationColorBlendMode;
			}
			set
			{
				this.m_DestinationColorBlendMode = (byte)value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x000A4C8C File Offset: 0x000A2E8C
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x0000F371 File Offset: 0x0000D571
		public BlendMode sourceAlphaBlendMode
		{
			get
			{
				return (BlendMode)this.m_SourceAlphaBlendMode;
			}
			set
			{
				this.m_SourceAlphaBlendMode = (byte)value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x000A4CA4 File Offset: 0x000A2EA4
		// (set) Token: 0x060026FF RID: 9983 RVA: 0x0000F37C File Offset: 0x0000D57C
		public BlendMode destinationAlphaBlendMode
		{
			get
			{
				return (BlendMode)this.m_DestinationAlphaBlendMode;
			}
			set
			{
				this.m_DestinationAlphaBlendMode = (byte)value;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x000A4CBC File Offset: 0x000A2EBC
		// (set) Token: 0x06002701 RID: 9985 RVA: 0x0000F387 File Offset: 0x0000D587
		public BlendOp colorBlendOperation
		{
			get
			{
				return (BlendOp)this.m_ColorBlendOperation;
			}
			set
			{
				this.m_ColorBlendOperation = (byte)value;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x000A4CD4 File Offset: 0x000A2ED4
		// (set) Token: 0x06002703 RID: 9987 RVA: 0x0000F392 File Offset: 0x0000D592
		public BlendOp alphaBlendOperation
		{
			get
			{
				return (BlendOp)this.m_AlphaBlendOperation;
			}
			set
			{
				this.m_AlphaBlendOperation = (byte)value;
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000A4CEC File Offset: 0x000A2EEC
		public static bool operator ==(RenderTargetBlendState left, RenderTargetBlendState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000A4D08 File Offset: 0x000A2F08
		public static bool operator !=(RenderTargetBlendState left, RenderTargetBlendState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeFieldInfoPtr_m_WriteMask;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceColorBlendMode;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeFieldInfoPtr_m_DestinationColorBlendMode;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceAlphaBlendMode;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeFieldInfoPtr_m_DestinationAlphaBlendMode;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorBlendOperation;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaBlendOperation;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040022D8 RID: 8920
		[FieldOffset(0)]
		public byte m_WriteMask;

		// Token: 0x040022D9 RID: 8921
		[FieldOffset(1)]
		public byte m_SourceColorBlendMode;

		// Token: 0x040022DA RID: 8922
		[FieldOffset(2)]
		public byte m_DestinationColorBlendMode;

		// Token: 0x040022DB RID: 8923
		[FieldOffset(3)]
		public byte m_SourceAlphaBlendMode;

		// Token: 0x040022DC RID: 8924
		[FieldOffset(4)]
		public byte m_DestinationAlphaBlendMode;

		// Token: 0x040022DD RID: 8925
		[FieldOffset(5)]
		public byte m_ColorBlendOperation;

		// Token: 0x040022DE RID: 8926
		[FieldOffset(6)]
		public byte m_AlphaBlendOperation;

		// Token: 0x040022DF RID: 8927
		[FieldOffset(7)]
		public byte m_Padding;
	}
}
