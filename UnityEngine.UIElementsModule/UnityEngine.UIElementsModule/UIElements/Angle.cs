using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017B RID: 379
	[StructLayout(2)]
	public struct Angle
	{
		// Token: 0x06001BFB RID: 7163 RVA: 0x0007F950 File Offset: 0x0007DB50
		// Note: this type is marked as 'beforefieldinit'.
		static Angle()
		{
			Il2CppClassPointerStore<Angle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Angle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Angle>.NativeClassPtr);
			Angle.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Angle>.NativeClassPtr, "m_Value");
			Angle.NativeFieldInfoPtr_m_Unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Angle>.NativeClassPtr, "m_Unit");
			Angle.NativeMethodInfoPtr_None_Internal_Static_Angle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667356);
			Angle.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667357);
			Angle.NativeMethodInfoPtr__ctor_Public_Void_Single_AngleUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667358);
			Angle.NativeMethodInfoPtr__ctor_Private_Void_Single_Unit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667359);
			Angle.NativeMethodInfoPtr_ToDegrees_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667360);
			Angle.NativeMethodInfoPtr_op_Implicit_Public_Static_Angle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667361);
			Angle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Angle_Angle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667362);
			Angle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Angle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667363);
			Angle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667364);
			Angle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667365);
			Angle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Angle>.NativeClassPtr, 100667366);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0007FA84 File Offset: 0x0007DC84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323511, RefRangeEnd = 323513, XrefRangeStart = 323511, XrefRangeEnd = 323511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Angle None()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_None_Internal_Static_Angle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x0007FAB4 File Offset: 0x0007DCB4
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x0000CA48 File Offset: 0x0000AC48
		public unsafe float value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_get_value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0007FAE4 File Offset: 0x0007DCE4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 286583, RefRangeEnd = 286597, XrefRangeStart = 286583, XrefRangeEnd = 286597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Angle(float value, AngleUnit unit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr__ctor_Public_Void_Single_AngleUnit_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0007FB24 File Offset: 0x0007DD24
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 286583, RefRangeEnd = 286597, XrefRangeStart = 286583, XrefRangeEnd = 286597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Angle(float value, Angle.Unit unit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr__ctor_Private_Void_Single_Unit_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0007FB64 File Offset: 0x0007DD64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 323513, RefRangeEnd = 323518, XrefRangeStart = 323513, XrefRangeEnd = 323513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ToDegrees()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_ToDegrees_Public_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0007FB94 File Offset: 0x0007DD94
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 323518, RefRangeEnd = 323546, XrefRangeStart = 323518, XrefRangeEnd = 323518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Angle(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_op_Implicit_Public_Static_Angle_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0007FBD4 File Offset: 0x0007DDD4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 323546, RefRangeEnd = 323585, XrefRangeStart = 323546, XrefRangeEnd = 323546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Angle lhs, Angle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Angle_Angle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0007FC20 File Offset: 0x0007DE20
		[CallerCount(0)]
		public unsafe bool Equals(Angle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Angle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0007FC60 File Offset: 0x0007DE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323585, XrefRangeEnd = 323588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0007FCA4 File Offset: 0x0007DEA4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 323589, RefRangeEnd = 323599, XrefRangeStart = 323588, XrefRangeEnd = 323589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0007FCD4 File Offset: 0x0007DED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323622, RefRangeEnd = 323623, XrefRangeStart = 323599, XrefRangeEnd = 323622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Angle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0000CA36 File Offset: 0x0000AC36
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Angle>.NativeClassPtr, ref this));
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0007FD00 File Offset: 0x0007DF00
		public static Angle Degrees(float value)
		{
			return new Angle(value, AngleUnit.Degree);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0007FD1C File Offset: 0x0007DF1C
		public static Angle Gradians(float value)
		{
			return new Angle(value, AngleUnit.Gradian);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0007FD38 File Offset: 0x0007DF38
		public static Angle Radians(float value)
		{
			return new Angle(value, AngleUnit.Radian);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0007FD54 File Offset: 0x0007DF54
		public static Angle Turns(float value)
		{
			return new Angle(value, AngleUnit.Turn);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x0000CA51 File Offset: 0x0000AC51
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x0000CA59 File Offset: 0x0000AC59
		public AngleUnit unit
		{
			get
			{
				return (AngleUnit)this.m_Unit;
			}
			set
			{
				this.m_Unit = (Angle.Unit)value;
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0000CA62 File Offset: 0x0000AC62
		public bool IsNone()
		{
			return this.m_Unit == Angle.Unit.None;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0007FD70 File Offset: 0x0007DF70
		public float ToGradians()
		{
			float num;
			switch (this.m_Unit)
			{
			case Angle.Unit.Degree:
				num = this.m_Value * 10f / 9f;
				break;
			case Angle.Unit.Gradian:
				num = this.m_Value;
				break;
			case Angle.Unit.Radian:
				num = this.m_Value * 200f / 3.1415927f;
				break;
			case Angle.Unit.Turn:
				num = this.m_Value * 400f;
				break;
			case Angle.Unit.None:
				num = 0f;
				break;
			default:
				num = 0f;
				break;
			}
			return num;
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0007FDF8 File Offset: 0x0007DFF8
		public float ToRadians()
		{
			float num;
			switch (this.m_Unit)
			{
			case Angle.Unit.Degree:
				num = this.m_Value * 3.1415927f / 180f;
				break;
			case Angle.Unit.Gradian:
				num = this.m_Value * 3.1415927f / 200f;
				break;
			case Angle.Unit.Radian:
				num = this.m_Value;
				break;
			case Angle.Unit.Turn:
				num = this.m_Value * 3.1415927f * 2f;
				break;
			case Angle.Unit.None:
				num = 0f;
				break;
			default:
				num = 0f;
				break;
			}
			return num;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0007FE84 File Offset: 0x0007E084
		public float ToTurns()
		{
			float num;
			switch (this.m_Unit)
			{
			case Angle.Unit.Degree:
				num = this.m_Value / 360f;
				break;
			case Angle.Unit.Gradian:
				num = this.m_Value / 400f;
				break;
			case Angle.Unit.Radian:
				num = this.m_Value / 6.2831855f;
				break;
			case Angle.Unit.Turn:
				num = this.m_Value;
				break;
			case Angle.Unit.None:
				num = 0f;
				break;
			default:
				num = 0f;
				break;
			}
			return num;
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0007FF00 File Offset: 0x0007E100
		public void ConvertTo(AngleUnit newUnit)
		{
			if (!true)
			{
			}
			float num;
			switch (newUnit)
			{
			case AngleUnit.Degree:
				num = this.ToDegrees();
				break;
			case AngleUnit.Gradian:
				num = this.ToGradians();
				break;
			case AngleUnit.Radian:
				num = this.ToRadians();
				break;
			case AngleUnit.Turn:
				num = this.ToTurns();
				break;
			default:
				throw new NotImplementedException();
			}
			if (!true)
			{
			}
			this.m_Value = num;
			this.m_Unit = (Angle.Unit)newUnit;
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0007FF68 File Offset: 0x0007E168
		public static bool operator !=(Angle lhs, Angle rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeFieldInfoPtr_m_Unit;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_None_Internal_Static_Angle_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_AngleUnit_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Single_Unit_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_ToDegrees_Public_Single_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Angle_Single_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Angle_Angle_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Angle_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001369 RID: 4969
		[FieldOffset(0)]
		public float m_Value;

		// Token: 0x0400136A RID: 4970
		[FieldOffset(4)]
		public Angle.Unit m_Unit;

		// Token: 0x0200049C RID: 1180
		public enum Unit
		{
			// Token: 0x04002B29 RID: 11049
			Degree,
			// Token: 0x04002B2A RID: 11050
			Gradian,
			// Token: 0x04002B2B RID: 11051
			Radian,
			// Token: 0x04002B2C RID: 11052
			Turn,
			// Token: 0x04002B2D RID: 11053
			None
		}
	}
}
